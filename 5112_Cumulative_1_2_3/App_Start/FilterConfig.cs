using System.Web;
using System.Web.Mvc;

namespace _5112_Cumulative_1_2_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
