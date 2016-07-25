using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePage.Components.ViewModels
{
    public sealed class EmptyComponentViewModel : BaseComponentViewModel
    {
        public string InnerModel;

        public EmptyComponentViewModel()
        {
            Index = 0;
            InnerModel = string.Empty;
        }
    }
}