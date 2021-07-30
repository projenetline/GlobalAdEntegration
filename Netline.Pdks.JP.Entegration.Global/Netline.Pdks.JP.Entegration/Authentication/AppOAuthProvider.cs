using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Netline.Pdks.JP.Entegration.Authentication
{
    internal class AppOAuthProvider : OAuthAuthorizationServerProvider
    {
        

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            //Burada client validation kullanmadık. İstersek custom client tipleri ile client tipine görede validation sağlayabiliriz.
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" }); // Farklı domainlerden istek sorunu yaşamamak için

            //Burada kendi authentication yöntemimizi belirleyebiliriz.Veritabanı bağlantısı vs...
            if (context.UserName == "NetlineGlobal" && context.Password == "NetlineGlobal2021!")
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                identity.AddClaim(new Claim("name", context.UserName));
                identity.AddClaim(new Claim("yetki", "Admin"));

                context.Validated(identity);
            }
            else
            {
                context.SetError("Geçersiz istek", "Hatalı kullanıcı bilgisi");
            }



        }
    }
}