using SinglePage.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePage.Components.ViewModels
{
    public class CallToActionViewModel: BaseComponentViewModel
    {
        public CallToActionViewModel()
        {
            ControllerName = "CallToAction";
            Name = "CTA";
            LongName = "Call to Action";

            //SinglePageRegisteredComponents.Register(this);
        }

    }
}