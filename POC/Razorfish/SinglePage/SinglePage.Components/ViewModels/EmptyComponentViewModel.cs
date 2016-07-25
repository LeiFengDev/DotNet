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