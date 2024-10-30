using System.Web;
using System.Web.Mvc;

namespace K22CNT2TaDinhThanhDoanh_2210900096
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
