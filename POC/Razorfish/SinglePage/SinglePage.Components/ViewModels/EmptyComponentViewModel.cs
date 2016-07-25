using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePage.Components.ViewModels
{
    public sealed class EmptyComponentViewModel : BaseComponentViewModel
    {
        public EmptyComponentViewModel()
        {
            //ControllerName = controllerName;
            Name = "NoName";
            LongName = "Empty Component";
            Index = 0;

        }
    }
}