using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SinglePage.Components.ViewModels;

namespace SinglePage.Components.Controllers
{
    public class CallToActionController : BaseComponentController
    {
        public override ActionResult Index(int index, string json = null)
        {
            var model = new CallToActionViewModel();
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    model.InnerModel = Newtonsoft.Json.JsonConvert.DeserializeObject<CallToActionViewModel.CtaInnerVm>(json);
                }
                catch (Exception)
                {
                    model.InnerModel = null;
                    //throw;
                }
            }

            ViewBag.Index = index;
            return View(model);
        }
    }
}
