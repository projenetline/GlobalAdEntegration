using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security.Tokens;

namespace Netline.Pdks.JP.Rnd
{
    class Program
    {
        static void Main(string[] args)
        {


            string continue_= "E";



            while (continue_ == "E")
            {


                string url = "http://localhost:8080/logo/services/PntCard?wsdl";
                string credid = "admin";
                string credpassword = "net_123";

                StringBuilder rawSOAP = new StringBuilder();
                rawSOAP.AppendLine("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:cus=\"http://customization.LogoPlatformTailor.com\">");
                rawSOAP.AppendLine(BuildSoapHeader(credid, credpassword));
                rawSOAP.AppendLine(@"<soapenv:Body><cus:upadatePntCard>");
                rawSOAP.AppendLine("<cus:firm>1</cus:firm><cus:period>1</cus:period><cus:language>TRTR</cus:language>");
                rawSOAP.AppendLine(@"</cus:upadatePntCard>");
                rawSOAP.AppendLine(@"</soapenv:Body>");
                rawSOAP.AppendLine(@"</soapenv:Envelope>");
                string SOAPObj = rawSOAP.ToString();
                using (var wb = new WebClient())
                {

                    wb.Credentials = new NetworkCredential(credid, credpassword);
                    var responseVal = wb.UploadString(url, "POST", SOAPObj);
                    Console.WriteLine(responseVal);
                }
                continue_ = Console.ReadLine();
            }

            Console.ReadKey();
        }
        private static string BuildSoapHeader(string credid, string credpassword)
        {
            StringBuilder rawSOAP= new StringBuilder();


            rawSOAP.AppendLine(@"<soapenv:Header>");
            rawSOAP.AppendLine(@"<wsse:Security soapenv:mustUnderstand=""1"" xmlns:wsse=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"" xmlns:wsu=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"">");
            rawSOAP.AppendLine(@"<wsse:UsernameToken wsu:Id=""UsernameToken-D1A5C91F8C11FC7F2614479411111111"">");
            rawSOAP.AppendLine(@"<wsse:Username>" + credid + "</wsse:Username>");
            rawSOAP.AppendLine(@"<wsse:Password Type=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"">" + credpassword + "</wsse:Password>");
            rawSOAP.AppendLine(@"</wsse:UsernameToken>");
            rawSOAP.AppendLine(@"</wsse:Security>");
            rawSOAP.AppendLine(@"</soapenv:Header>");
            return rawSOAP.ToString();
        }

    }
}
