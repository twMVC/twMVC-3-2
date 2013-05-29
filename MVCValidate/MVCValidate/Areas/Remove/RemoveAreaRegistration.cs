using System.Web.Mvc;

namespace MVCValidate.Areas.Remove
{
    public class RemoveAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Remove";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Remove_default",
                "Remove/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
