namespace SinglePage.Components.ViewModels
{
    public class IconLinkViewModel : BaseComponentViewModel
    {
        public IconLinkInnerVm InnerModel;

        public IconLinkViewModel()
        {
            //Index = 3;  // must match the RegisteredComponentInfo for IconLink
        }

        public class IconLinkInnerVm
        {
            public string WrapperClass { get; set; }
            public string Target { get; set; }
            public string TargetUrl { get; set; }
            public string IconCssClass { get; set; }
            public string IconText { get; set; }
        }
    }
}