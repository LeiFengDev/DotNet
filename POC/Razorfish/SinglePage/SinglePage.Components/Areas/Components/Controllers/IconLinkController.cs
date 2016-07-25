using System;
using System.Web.Mvc;
using SinglePage.Components.ViewModels;

namespace SinglePage.Components.Controllers
{
    public class IconLinkController : BaseComponentController
    {
        public override ActionResult Index(int index, string json = null)
        {
            var model = new IconLinkViewModel();
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    model.InnerModel = Newtonsoft.Json.JsonConvert.DeserializeObject<IconLinkViewModel.IconLinkInnerVm>(json);
                }
                catch (Exception)
                {
                    model.InnerModel = null;
                    //throw;
                }
            }

            //ViewBag.Index = index;
            return View(model);
        }
    }
}
