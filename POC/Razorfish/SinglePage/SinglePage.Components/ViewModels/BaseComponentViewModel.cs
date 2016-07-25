using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePage.Components.ViewModels
{
    public class BaseComponentViewModel
    {
        //public string Type { get; set; }

        public int Index { get; set; }

        private string _controllerName = "BaseComponent";
        public string ControllerName
        {
            get { return _controllerName; }
            protected set { _controllerName = value; }
        }

        private string _name = "Unknown";
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        private string _longName = "Unnamed Component";
        public string LongName
        {
            get { return _longName; }
            protected set { _longName = value; }
        }

        
    }
}