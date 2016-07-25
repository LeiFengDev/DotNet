using System.Collections.Generic;
namespace SinglePage.Components.Models
{
    public static class SinglePageRegisteredComponents
    {
        public static List<RegisteredComponentInfo> ComponentList
        {
            get {
                return new List<RegisteredComponentInfo>
                    {
                        new RegisteredComponentInfo
                            {
                                AreaName = "Components",
                                ControllerName = "BaseComponent",
                                ActionName = "Index",
                                Name = "NoName",
                                Description = "Empty Component",
                                Index = 0
                            },
                        new RegisteredComponentInfo
                            {
                                AreaName = "Components",
                                ControllerName = "CallToAction",
                                ActionName = "Index",
                                Name = "CTA",
                                Description = "Call to Action",
                                Index = 1
                            }
                    };
            }
        }

    }
}