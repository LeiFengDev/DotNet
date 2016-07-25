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
        public override ActionResult Index(int index)
        {
            ViewBag.Index = index;
            return View(new CallToActionViewModel());
        }
    }
}
