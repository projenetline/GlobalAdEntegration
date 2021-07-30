using Netline.Pdks.JP.Entegration.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Netline.Pdks.JP.Entegration.Controllers
{
    public class AuthController : ApiController
    {
        /// <summary>
        /// Token almak için
        /// </summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("api/Auth/GetToken")]
        public async Task<TokenResponse> GetToken(TokenRequest request)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(Request.RequestUri.GetLeftPart(UriPartial.Authority))
            };

            var content = new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("grant_type", request.grant_type),
            new KeyValuePair<string, string>("username", request.Username),
            new KeyValuePair<string, string>("password", request.Password)
        });

            var result = await client.PostAsync("/gettoken", content);
            string resultContent = await result.Content.ReadAsStringAsync();
            resultContent = resultContent.Replace(".issued", "issued").Replace(".expires", "expires");
            TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(resultContent);

            tokenResponse.issued = DateTime.Now;
            tokenResponse.expires = DateTime.Now.AddSeconds(tokenResponse.expires_in);

            return tokenResponse;
        }
    }
}
