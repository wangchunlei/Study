$(document).ready(function () {
    $("#GridMode, #CustID", "#ExternalPosition").bind('click', function () {
        $("#submit").click();
    });
});

var tempCheckedRecords = new Array();
function checkedRecords(sender, args) {
    var gddobj = $find('GenericDropDown');
    var checkboxes = args._target;
    if (checkboxes.checked) {
        tempCheckedRecords.push(checkboxes.value);
    }
    else {
        tempCheckedRecords.pop(checkboxes.value);
    }
    var selText = "";
    $.each(tempCheckedRecords, function (index, value) {
        selText += " " + value;
    });
    if (tempCheckedRecords.length == 0)
        selText = "";
    gddobj.setText(selText);


}

function lockRecords(sender, args) {
    $.each(tempCheckedRecords, function (index, element) {
        var primary = Sys.Serialization.JavaScriptSerializer.deserialize(args.data.GridRequestParams)["PrimaryKeyValues"];
        if (args.getRequestType() == "BeginEdit" && element == primary) {
            args.cancel = true;
        }
    });
}