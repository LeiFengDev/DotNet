using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SinglePage.Components.ViewModels;

namespace SinglePage.Components.Controllers
{
    public class BaseComponentController : Controller
    {
        public virtual ActionResult Index(int index, string json = null)
        {
            ViewBag.Index = index;
            return View(new EmptyComponentViewModel());
        }

    }
}
