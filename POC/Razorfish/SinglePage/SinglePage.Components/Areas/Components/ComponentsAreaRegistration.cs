using System.Web.Mvc;

namespace SinglePage.Components.Areas
{
    public class ComponentsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Components"; }
        }


        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Components_default",
                "Components/{controller}/{action}/{id}",
                new { id = UrlParameter.Optional },
                namespaces: new[] { "SinglePage.Components.Controllers" }
            );

        }
    }
}