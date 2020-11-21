using System.Web;
using System.Web.Mvc;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
