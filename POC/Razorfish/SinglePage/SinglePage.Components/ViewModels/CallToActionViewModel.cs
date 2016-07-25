namespace SinglePage.Components.ViewModels
{
    public class CallToActionViewModel: BaseComponentViewModel
    {
        public CtaInnerVm InnerModel;

        public CallToActionViewModel()
        {
            Index = 1;  // must match the RegisteredComponentInfo for CTA
        }

        public class CtaInnerVm
        {
            public string WrapperClass { get; set; }
            public string Target { get; set; }
            public string TargetUrl { get; set; }
            public string ImageSrcUrl { get; set; }
            public string ImageAlt { get; set; }
            public int ImageWidth { get; set; }
            public int ImageHeight { get; set; }
            public string TextCaption { get; set; }
            public string TextContent { get; set; }

        }

    }
}