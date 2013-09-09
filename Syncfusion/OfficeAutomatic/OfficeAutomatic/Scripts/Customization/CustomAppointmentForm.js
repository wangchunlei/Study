
$(document).ready(function () {

    $(".ClientAppointment").css("visibility", "hidden");

    $("#Save").bind("click", function saveAppointment() {
        var newApp = new Syncfusion.Schedule.ClientAppointment();
        newApp.set_Subject($("#Subject").val());
        newApp.set_Location($("#Location").val());
        newApp.set_Description($("#Description").val());
        newApp.set_Owner($("#Owner").val());
        newApp.set_Priority($("#Priority").val());
        newApp.set_Reminder($("#Reminder").val());
        newApp.set_Recurrence($("#Recurrence")[0].checked);
        if ($("#Recurrence")[0].checked) {
            var frq = $("#RecurrenceFrequency").val();
            var _rules = "FREQ=";
            if (frq == "DAILY") {
                _rules = _rules + "DAILY;INTERVAL=" + $("#RecurrenceInterval").val() + ";RANGE=ENDBY";
            }
            else if (frq == "WEEKLY") {
                _rules = _rules + "WEEKLY;BYDAY=MO,WE,FR;INTERVAL=" + $("#RecurrenceInterval").val() + ";RANGE=ENDBY";
            }
            else if (frq == "MONTHLY") {
                _rules = _rules + "MONTHLY;BYMONTHDAY=" + new Date().getDate() + ";INTERVAL=" + $("#RecurrenceInterval").val() + ";RANGE=ENDBY";
            }
            else if (frq == "YEARLY") {
                _rules = _rules + "YEARLY;BYMONTHDAY=" + new Date().getDate() + ";INTERVAL=" + $("#RecurrenceInterval").val() + ";BYMONTH=" + new Date().getMonth() + ";RANGE=ENDBY";
            }
            context.set_RecurrenceRules(_rules);
        }
        newApp.set_RecurrenceFrequency($("#RecurrenceFrequency").val());
        newApp.set_RecurrenceInterval($("#RecurrenceInterval").val());
        // Recurrence
        if (newApp.get_Recurrence()) {
            newApp.set_StartTime(new Date($("#RecurrenceStartDate").val() + " " + $("#RecurrenceStartTime").val()));
            newApp.set_EndTime(new Date($("#RecurrenceEndDate").val() + " " + $("#RecurrenceEndTime").val()));
            context.set_RecurrenceStart(new Date(newApp.get_StartTime()).format("MM/dd/yyyy"));
            context.set_RecurrenceEnd(new Date(newApp.get_EndTime()).format("MM/dd/yyyy"));
        }
        else {
            newApp.set_StartTime(new Date($("#StartDate").val() + " " + $("#StartTime").val()));
            newApp.set_EndTime(new Date($("#EndDate").val() + " " + $("#EndTime").val()));
        }

        if (newApp.get_Subject() != "" && newApp.get_StartTime() < newApp.get_EndTime()) {
            context.set_Categorize($("#Categorize").val()); // Add the custom class name
            context.saveAppointment(newApp);
        }
        else if (newApp.get_Subject() == "") {
            alert(" Subject field should not be empty ");
        }
        else if (newApp.get_StartTime() >= newApp.get_EndTime()) {
            alert(" Start Time should be smaller than End Time ");
        }
        closeAppointmentForm();
    })

    $("#Cancel").bind("click", function saveAppointment() {
        closeAppointmentForm();
    });

    $("#Delete").bind("click", function deleteAppointment(e) {
        var result = context.DeleteClick();
        if (result)
            closeAppointmentForm();
    });

    $("#submit").bind("click", function ChangeView(event) {
        var selectedView = $find("schedule1").get_CurrentView() == "2" ? "Week" :
            $find("schedule1").get_CurrentView() == "3" ? "WorkWeek" :
            $find("schedule1").get_CurrentView() == "4" ? "Month" : "Day";
        $("#CurrentView").val(selectedView);
        var selectedDate = $find("schedule1").get_CurrentDate();
        $("#CurrentDate").val(selectedDate);
    });

    $("#Recurrence").bind("change", function Recurence(event) {
        if (this.checked) {
            $("#Recurrencediv").css("display", "block");
            $("#ClientAppointmentWindow").parent().css("height", "460px");
        }
        else {
            $("#Recurrencediv").css("display", "none");
            $("#ClientAppointmentWindow").parent().css("height", "360px");
        }
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

function showAppointmentDetails(sender, args) {
    // sender - schedule control details
    // args - id -> selected appointment id
    // args - currentItem -> selected appointment details
    args.cancel = true;
    context = sender;
    showAppointmentForm();
    if (args._id != '') {
        var aptDetails = sender.get_AppointmentList()[args._id];
        if (aptDetails != null) {
            $("#Subject").val(aptDetails.Subject);
            $("#Description").val(aptDetails.Description);
            $("#Location").val(aptDetails.Location);
            $("#Categorize").val(aptDetails.AppointmentCategorize!=""?aptDetails.AppointmentCategorize:"None");
            $("#Owner").val(aptDetails.Owner);
            $("#Priority").val(aptDetails.Priority);
            $("#Reminder").val(aptDetails.Reminder);
            $("#Recurrence")[0].checked = (aptDetails.Recurrence);
            $("#RecurrenceFrequency").val(aptDetails.RecurrenceType);
            $("#RecurrenceInterval").val(aptDetails.RecurrenceTypeCount);
            if (aptDetails.Recurrence == 1) {
                $("#StartDate").val("");
                $("#EndDate").val("");
                $("#StartTime").val("00:00");
                $("#EndTime").val("00:00");

                $("#RecurrenceStartDate").val(new Date(aptDetails.ParentStartTime).format("MM/dd/yyyy"));
                $("#RecurrenceEndDate").val(new Date(aptDetails.ParentEndTime).format("MM/dd/yyyy"));
                $("#RecurrenceStartTime").val(new Date(aptDetails.ParentStartTime).format("HH:mm"));
                $("#RecurrenceEndTime").val(new Date(aptDetails.ParentEndTime).format("HH:mm"));
                $("#Recurrencediv").css("display", "block");
                $("#ClientAppointmentWindow").parent().css("height", "460px");
            }
            else {
                $("#StartDate").val(new Date(aptDetails.StartTime).format("MM/dd/yyyy"));
                $("#EndDate").val(new Date(aptDetails.EndTime).format("MM/dd/yyyy"));
                $("#StartTime").val(new Date(aptDetails.StartTime).format("HH:mm"));
                $("#EndTime").val(new Date(aptDetails.EndTime).format("HH:mm"));

                $("#RecurrenceStartDate").val("");
                $("#RecurrenceEndDate").val("");
                $("#RecurrenceStartTime").val("00:00");
                $("#RecurrenceEndTime").val("00:00");
            }
        }
    }
}

function clearDetails() {
    $("#Subject").val("");
    $("#Description").val("");
    $("#Location").val("");
    $("#Categorize").val("None");
    $("#StartDate").val("");
    $("#EndDate").val("");
    $("#StartTime").val(new Date().format("00:00"));
    $("#EndTime").val(new Date().format("00:00"));
    $("#Owner").val("1");
    $("#Priority").val("0");
    $("#Reminder").val("-1");
    $("#Recurrence")[0].checked = false;
    $("#RecurrenceFrequency").val("Daily");
    $("#RecurrenceInterval").val("1");
    $("#RecurrenceStartDate").val("");
    $("#RecurrenceEndDate").val("");
    $("#RecurrenceStartTime").val("00:00");
    $("#RecurrenceEndTime").val("00:00");
}

function cellUpDblClick(sender, args) {
    // sender - schedule control details
    // args - selectedDate -> selected cell's date
    // args - selectedStartTime -> selected cell's start time
    // args - selectedEndTime -> selected cell's end time
    // args - selectedResourceId -> selected cell's owner id's
    args.cancel = true;
    context = sender;
    showAppointmentForm();
    clearDetails();
    $("#StartDate").val(args._selectedDate);
    $("#EndDate").val(args._selectedDate);
    $("#StartTime").val(args._selectedStartTime);
    $("#EndTime").val(args._selectedEndTime);
    $("#Owner").val(args._selectedResourceId);
    $("#RecurrenceStartDate").val(args._selectedDate);
    $("#RecurrenceEndDate").val(args._selectedDate);
    $("#RecurrenceStartTime").val(args._selectedStartTime);
    $("#RecurrenceEndTime").val(args._selectedEndTime);
}

function showAppointmentForm() {
    $("#ClientAppointmentWindow").addClass('clientAppointment');
    $(".ClientAppointment").css("visibility", "visible");
    $("#ClientAppointmentWindow").dialog("open");
    $("#ClientAppointmentWindow").parent().css("overflow", "hidden");
    $("#ClientAppointmentWindow").parent().css("height", "360px");
    $("#ClientAppointmentWindow").parent().css("width", "580px");
    $("#Recurrencediv").css("display", "none");
}

function closeAppointmentForm() {
    $("#ClientAppointmentWindow").dialog("close");
    clearDetails();
}



