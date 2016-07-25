using System.Linq;
using SinglePage.Components.Models;

namespace SinglePage.Components.ViewModels
{
    public class BaseComponentViewModel
    {
        public int Index { get; set; }

        public RegisteredComponentInfo ComponentInfo
        {
            get
            {
                return SinglePageRegisteredComponents.ComponentList.FirstOrDefault(c => c.Index == this.Index);
            }
        }
    }
}