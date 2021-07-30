using System.Web;
using System.Web.Mvc;

namespace Netline.Pdks.JP.Entegration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
