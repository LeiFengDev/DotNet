namespace SinglePage.Components.Models
{
    public class RegisteredComponentInfo
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string AreaName { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }

        public string InnerItemTypeString { get; set; }
    }
}