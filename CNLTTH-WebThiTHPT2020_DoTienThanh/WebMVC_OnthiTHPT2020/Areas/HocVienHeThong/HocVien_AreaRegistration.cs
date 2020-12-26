using System.Web.Mvc;

namespace WebMVC_OnthiTHPT2020.Areas.HocVienHeThong
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HocVienHeThong";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "WebMVC_OnthiTHPT2020.Areas.HocVienHeThong.Controllers" }
            );
        }
    }
}