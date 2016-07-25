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
                                Index = 0,
                                InnerItemTypeString = "System.String"
                            },
                        new RegisteredComponentInfo
                            {
                                AreaName = "Components",
                                ControllerName = "CallToAction",
                                ActionName = "Index",
                                Name = "CTA",
                                Description = "Call to Action",
                                Index = 1,
                                InnerItemTypeString = "SinglePage.Components.ViewModels.CallToActionViewModel.CtaInnerVm"
                            },
                        new RegisteredComponentInfo
                            {
                                AreaName = "Components",
                                ControllerName = "BulletedList",
                                ActionName = "Index",
                                Name = "BulletedList",
                                Description = "Bulleted List",
                                Index = 2,
                                InnerItemTypeString = "SinglePage.Components.ViewModels.BulletedListViewModel.ListInnerVm"
                            },
                        //new RegisteredComponentInfo
                        //    {
                        //        AreaName = "Components",
                        //        ControllerName = "IconLink",
                        //        ActionName = "Index",
                        //        Name = "IconLink",
                        //        Description = "Icon Link",
                        //        Index = 3,
                        //        InnerItemTypeString = "SinglePage.Components.ViewModels.IconLinkViewModel.IconLinkInnerVm"
                        //    }
                    };
            }
        }

    }
}