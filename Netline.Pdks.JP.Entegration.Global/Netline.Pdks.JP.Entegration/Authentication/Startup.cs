using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

using System.Web.Http;
[assembly: OwinStartup(typeof(Netline.Pdks.JP.Entegration.Authentication.Startup))]
namespace Netline.Pdks.JP.Entegration.Authentication
{
    
    public class Startup
    {
        public static string PublicClientId { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            // Configure Web API to use only bearer token authentication.  
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            ConfigureAuth(app);
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the application for OAuth based flow  
            PublicClientId = "self";
            var oAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/gettoken"),
                Provider = new AppOAuthProvider(),
                AuthorizeEndpointPath = new PathString("/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                AllowInsecureHttp = true,
                
            };

            app.UseOAuthAuthorizationServer(oAuthOptions);//Oauth2 ayarlarinin yapilmasini saglar
            //Http request header'daki bearer token olup olmadigini anlamak icin kullanilir.
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}