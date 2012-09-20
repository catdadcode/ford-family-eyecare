using System.Web.Mvc;

namespace FordFamilyEyeCare.Web.Areas.AjaxServices
{
    public class AjaxServicesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AjaxServices";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AjaxServices_default",
                "AjaxServices/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
