
$(document).ready(function () {
    $("#ClientSideOnKeyDown").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnKeyDown(KeyDown);
        else
            scheduleObj.remove_OnKeyDown(KeyDown);
    });

    $("#ClientSideOnAppointmentSelection").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnAppointmentSelection(showAppointmentDetails);
        else
            scheduleObj.remove_OnAppointmentSelection(showAppointmentDetails);
    });
    $("#ClientSideOnCellDoubleClick").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnCellUpDblClick(cellUpDblClick);
        else
            scheduleObj.remove_OnCellUpDblClick(cellUpDblClick);
    });
    $("#ClientSideOnContextMenuClick").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnContextMenuClick(ContextMenuClick);
        else
            scheduleObj.remove_OnContextMenuClick(ContextMenuClick);
    });
    $("#ClientSideOnCellSingleClick").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnCellSingleClick(CellSingleClick);
        else
            scheduleObj.remove_OnCellSingleClick(CellSingleClick);
    });
    $("#ClientSideOnActionSuccess").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnActionSuccess(OnActionSuccess);
        else
            scheduleObj.remove_OnActionSuccess(OnActionSuccess);
    });
    $("#ClientSideOnActionBegin").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnActionBegin(OnActionBegin);
        else
            scheduleObj.remove_OnActionBegin(OnActionBegin);
    });
    $("#ClientSideOnAppoinmentDoubleClick").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnAppointmentDoubleClick(OnAppointmentDoubleClick);
        else
            scheduleObj.remove_OnAppointmentDoubleClick(OnAppointmentDoubleClick);
    });
    $("#ClientSideOnAppoinmentSingleClick").bind("click", function (event) {
        var scheduleObj = $find("schedule1");
        if ($(this).is(':checked'))
            scheduleObj.add_OnAppointmentClick(OnAppointmentClick);
        else
            scheduleObj.remove_OnAppointmentClick(OnAppointmentClick);
    });

    $("#submit").bind("click", function ChangeView(event) {
        var selectedView = $find("schedule1").get_CurrentView() == "2" ? "Week" :
            $find("schedule1").get_CurrentView() == "3" ? "WorkWeek" :
            $find("schedule1").get_CurrentView() == "4" ? "Month" : "Day";
        $("#CurrentView").val(selectedView);
        var selectedDate = $find("schedule1").get_CurrentDate();
        $("#CurrentDate").val(selectedDate);
    });

    $("#EnableClientSideEvents").bind('click', function () {
        $("#submit").click();
    });
    $("#Clear").bind('click', function () {
        var event = document.getElementById('eventname');
        event.innerHTML = "";
    });
});
var context;

var line = "";
var browser = navigator.appName;
if (browser == "Microsoft Internet Explorer") {
    line = "<br/>";
}
else {
    line = "\n";
}

function KeyDown(sender, args) {
    jQuery.AddEventLog("mySchedule", "KeyDown", args);
} 

function showAppointmentDetails(sender, args) {
    jQuery.AddEventLog("mySchedule", "showAppointmentDetails", args);
}

function cellUpDblClick(sender, args) {
    jQuery.AddEventLog("mySchedule", "cellUpDblClick", args);
}

function OnActionBegin(sender, args) {
    jQuery.AddEventLog("mySchedule", "OnActionBegin", args);
}

function OnActionSuccess(sender, args) {
    jQuery.AddEventLog("mySchedule", "OnActionSuccess", args);
}

function CellSingleClick(sender, args) {
    jQuery.AddEventLog("mySchedule", "CellSingleClick", args);
}

function ContextMenuClick(sender, args) {
    jQuery.AddEventLog("mySchedule", "ContextMenuClick", args);
}

function OnAppointmentClick(sender, args) {
    jQuery.AddEventLog("mySchedule", "OnAppointmentClick", args);
}

function OnAppointmentDoubleClick(sender, args) {
    jQuery.AddEventLog("mySchedule", "OnAppointmentDoubleClick", args);
}