# Requirements

Develop a simple one page site using the ASP.NET MVC framework in C#.  The sample site should be built with a modular approach, and contain one of the following:
 
* **Models**
* **Views**:   Separate views for layout, page, and controls
* **Controllers**
 
The one page also needs to incorporate two user controls that perform the following:
* **CTA**:   Implement as an image that links to google.com.
* **Bulleted List**:   List several bullets from a collection object that you create.  Select the most appropriate collection type.  The control should be rendered from an Action.

The solution will be delivered as a Visual Studio 2015 solution that can be successfully compiled and deployed to test.

# Solution

This solution contains 2 MVC project: 

* **SinglePage** is used to build up the main layout and containers, along with the design and content initialization for the loading of the control. 
* **SinglePage.MVC** focuses on implement the controls themselves, most of the compoents changes won't affect the first project SinglePage. The only changes for it is after done the changes, if the inner data the component consumed changed, we need to request the main project to update the data object to feed the control with the proper format (Json).

The 2 controls are: 

* **CTA** (Call to Action)
> Current CTA control works with Json object: 
> ```
> { "WrapperClass": "cta", "Target": "_blank", "TargetUrl": "https://www.google.com", "ImageSrcUrl": "https://www.google.ca/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png", "ImageAlt": "google.com", "ImageWidth": 272, "ImageHeight": 92, "TextCaption": "Google USA", "TextContent": "This is a CTA sample" }
> ```
* **BulletedList** (Bulleted List)
> Current BulletedList control works with Json object: 
> ```
> { "WrapperClass": "blist", "IsOrderedBullets": false, "ListCssClass": "list-disc", "ListItems": [{ "HasBadge": true, "BadgeNumber": 10, "ItemCssClass": null, "IconLinkItem": { "WrapperClass": "IconLink", "Target": "_blank", "TargetUrl": "https://www.google.ca/imghp", "IconCssClass": "fa fa-file-image-o", "IconText": "Google Image" } }, { "HasBadge": true, "BadgeNumber": 5, "ItemCssClass": null, "IconLinkItem": { "WrapperClass": "IconLink", "Target": "_blank", "TargetUrl": "https://news.google.ca/nwshp", "IconCssClass": "fa fa-newspaper-o", "IconText": "Google News" } }, { "HasBadge": true, "BadgeNumber": 4, "ItemCssClass": null, "IconLinkItem": { "WrapperClass": "IconLink", "Target": "_blank", "TargetUrl": "https://translate.google.ca/", "IconCssClass": "fa fa-file-text-o", "IconText": "Google Translate" } }, { "HasBadge": false, "BadgeNumber": 0, "ItemCssClass": null, "IconLinkItem": { "WrapperClass": "IconLink", "Target": "_blank", "TargetUrl": "https://www.google.ca/maps", "IconCssClass": "fa fa-map", "IconText": "Google Maps" } }, { "HasBadge": true, "BadgeNumber": 1, "ItemCssClass": null, "IconLinkItem": { "WrapperClass": "IconLink", "Target": "_blank", "TargetUrl": "https://www.youtube.com", "IconCssClass": "fa fa-youtube-play", "IconText": "Youtube" } }, { "HasBadge": true, "BadgeNumber": 11, "ItemCssClass": null, "IconLinkItem": { "WrapperClass": "IconLink", "Target": "_blank", "TargetUrl": "https://play.google.com/store", "IconCssClass": "fa fa-shopping-cart", "IconText": "Google Store" } }] }
> ```

With the json obj and Css classes, we can control all the details of the control UI, while the functionality of the controls are implemented in their own controllers and actions.

# Build and run

**Both project need to be built and published into same site to be full functional**. 
> Note: Missing deploying the **SinglePage.MVC** project will cause the Ajax call failure and error message popped up.

Please decide how to show the controls. Direcly select the dropdowns above, you will see the changes here. Currently we only have 2 controls. If you choose to display more than 2, empty placeholders will show up following the existing controls.
