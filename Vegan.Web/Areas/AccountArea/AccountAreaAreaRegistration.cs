using System.Web.Mvc;

namespace Vegan.Web.Areas.AccountArea
{
    public class AccountAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AccountArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AccountArea_default",
                "AccountArea/{controller}/{action}/{id}",
                new { action = "Register", id = UrlParameter.Optional }
            );
        }
    }
}