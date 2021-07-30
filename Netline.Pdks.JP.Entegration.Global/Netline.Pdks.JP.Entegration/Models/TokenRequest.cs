using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netline.Pdks.JP.Entegration.Models
{
    public class TokenRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string grant_type { get; set; }

    }

    public class TokenResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }     
        public DateTime issued { get; set; }
        public DateTime expires { get; set; }
      
    }
}