(function ($) {
    $(function () {

        var currentComponents = function () {
            return $("#rendererContainer > div[id^=component-]");
        }

        var containerAjaxLoad = function (actionUrl, $target, index, componentCssClass) {
            //var actionUrl = '@Url.Action("AjaxRendering", "Home")';
            return $.ajax({
                type: "GET",
                url: actionUrl,
                data: { index: index, css: componentCssClass },
                //dataType: "json",
                contentType: "application/json; charset=utf-8",
                cache: false,
                error: function (xhr, ajaxOptions, thrownError) {
                    alert("Ajax call failed: " + xhr.status + "(" + thrownError + ")");
                },
                success: function (result) {
                    if (index == 0)
                        $target.html(result);
                    else {
                        var $currentCompoents = currentComponents();

                        if (index > $currentCompoents.length)
                            $target.append(result);
                        else
                            $($currentCompoents[index]).before(result);
                    }
                }
            });
        };

        var containerLoadNext = function (actionUrl, $target, index, componentCssClass, max) {
            if (index > max)
                return;

            containerAjaxLoad(actionUrl, $target, index, componentCssClass).done(function () {
                containerLoadNext(actionUrl, $target, index + 1, componentCssClass, max);
            });
        };

        var controlsNumberChange = function (selectedNumber, actionUrl, componentCssClass) {
            var $existingComponents = currentComponents();
            var totalCurrentComponents = $existingComponents.length;

            if (totalCurrentComponents == selectedNumber)
                return;

            var $target = $("div#rendererContainer");
            if (!$target || $target.length <= 0) {
                console.log("Cannot find target container for controls; function stopped");
                return false;
            }

            if (selectedNumber == 0) {
                containerAjaxLoad(actionUrl, $target, 0, componentCssClass);
                return;
            }

            if (totalCurrentComponents == 0) {
                $("div#rendererContainer > #default").remove();
            }

            if (totalCurrentComponents < selectedNumber) {
                //for (var i = totalCurrentComponents + 1; i <= selectedNumber; i++) {
                //    //console.log("#" + i);
                //    containerAjaxLoad(actionUrl, $target, i, componentCssClass);
                //}
                containerLoadNext(actionUrl, $target, totalCurrentComponents + 1, componentCssClass, selectedNumber);

                return;
            }

            for (var i = totalCurrentComponents; i > selectedNumber; i--) {
                var $currentComponent = $($existingComponents[i - 1]);
                if (!$currentComponent || $currentComponent.length <= 0)
                    continue;

                $currentComponent.remove();
            }
        };

        var controlsStyleChange = function (selectedNumber, componentCssClass) {
            
            var $existingComponents = currentComponents();
            var totalCurrentComponents = $existingComponents.length;

            if (totalCurrentComponents > 0) 
                $existingComponents.attr("class", componentCssClass);
        };

        $(document).ready(function () {
            $("select.selectpicker").change(function () {
                var selectorId = $(this).attr("id");
                var selectorValue = $(this).val();
                var actionUrl = $(this).data("action");

                //console.log("id=" + selectorId);
                //console.log("val=" + selectorValue);
                //console.log("action=" + actionUrl);
                var selectedLayout = parseInt($("select#selectLayout").val());
                var selectedNumber = parseInt($("select#selectNumber").val());

                var componentCssClass = "col-sm-12";
                if (selectedNumber != 0 && selectedLayout == 1) {
                    componentCssClass = "col-sm-" + (12 / selectedNumber);
                }

                switch (selectorId) {
                    case "selectNumber":
                        controlsNumberChange(selectedNumber, actionUrl, componentCssClass);
                        if (selectedLayout == 1)
                            controlsStyleChange(selectedNumber, componentCssClass);
                        break;
                    case "selectLayout":
                        controlsStyleChange(selectedNumber, componentCssClass);
                        break;
                
                }

                
            });
        });
    });
}(jQuery));