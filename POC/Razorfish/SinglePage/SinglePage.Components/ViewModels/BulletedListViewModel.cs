using System.Collections.Generic;

namespace SinglePage.Components.ViewModels
{
    public class BulletedListViewModel : BaseComponentViewModel
    {
        public ListInnerVm InnerModel;

        public BulletedListViewModel()
        {
            Index = 2;  // must match the RegisteredComponentInfo for BulletedList
        }

        public class ListInnerVm
        {
            public string WrapperClass { get; set; }
            public bool IsOrderedBullets { get; set; }
            public string ListCssClass { get; set; }

            public List<DecoratedIconLink> ListItems { get; set; }
        }

        public class DecoratedIconLink
        {
            public bool HasBadge { get; set; }
            public int BadgeNumber { get; set; }
            public string ItemCssClass { get; set; }

            public IconLinkViewModel.IconLinkInnerVm IconLinkItem { get; set; }
        }
    }
}