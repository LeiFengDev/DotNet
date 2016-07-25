using System.Linq;
using System.Web.Mvc;
using SinglePage.Components.Models;

namespace SinglePage.Controllers
{
    public class HomeController : Controller
    {
        public string AppName { get { return typeof(MvcApplication).Assembly.GetName().Name; } }

        public HomeController()
        {
            ViewBag.AppName = typeof(MvcApplication).Assembly.GetName().Name;
            ViewBag.BrandName = "Razorfish";
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjaxRendering(int index, string css)
        {
            //return View();

            if (index == 0)
                return PartialView("~/Views/Home/Default.cshtml");

            var currentComponent = SinglePageRegisteredComponents.ComponentList.FirstOrDefault(c => c.Index == index)
                                    ?? SinglePageRegisteredComponents.ComponentList.FirstOrDefault(c => c.Index == 0);

            if (currentComponent == null)
                currentComponent = new RegisteredComponentInfo
                                    {
                                        AreaName = "Components",
                                        ControllerName = "BaseComponent",
                                        ActionName = "Index",
                                        Name = "NoName",
                                        Description = "Empty Component",
                                        Index = 0
                                    };

            ViewBag.Index = index;
            ViewBag.CssClass = css;
            return PartialView(currentComponent);
        }
        
    }
}