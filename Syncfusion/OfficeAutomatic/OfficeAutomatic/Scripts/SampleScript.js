var schedule = null;
var controlId = null;
var pageContext = this;

Sys.Application.add_load(function () {
    controlId = $(".sample-panel-margin").find("div:first").attr("id");
    if (controlId != null) {
        schedule = $find(controlId);
    }

    $(".sf-property-panel").find('input[class="hasDatepicker"]').bind("change", function (evt) {
        context.setCurrentState();
        $("#submit").click();
    });

});

$(document).ready(function () {
    if ($(".sf-property-panel").find('.divEventTrace').length <= 0) {
    $(".sf-property-panel").find('input[type="checkbox"]').bind("click", function (evt) {
        pageContext.setCurrentState();
        $("#submit").click();
    });
    }

    $(".sf-property-panel select").bind("change", function (evt) {
        if (this.id != "FileName") {
        pageContext.setCurrentState();
        $("#submit").click();
        }
    });

    $("#submit").bind("click", function () {
        var action = $(".sf-property-panel").find("form").attr('action').split("/");
        if (action[action.length - 1] == "TimeLineCustomization") {
            if (parseInt($("#StartHour_numerictextbox").val()) >= parseInt($("#EndHour_numerictextbox").val())) {
                window.alert("Error! Invalid start and end hours");
                return false;
            }
        }
        pageContext.setCurrentState();
    });


});

function calendarDateSelected() {
    $("#submit").click();
}

function setCurrentState() {
    if ($("#CurrentView").is("input")) {
        $("#CurrentView").val(schedule.get_CurrentView());
        $("#CurrentDate").val(schedule.get_CurrentDate());
    }
}

function ContextMenuItemClick(sender, args) {
    var displayString = "";
    var newApp = new Syncfusion.Schedule.ClientAppointment();
    newApp.set_Subject("You are clicked " + $(args._currentItem).text());
    if (newApp.get_Subject() != "") {
        sender.saveAppointment(newApp);
    }
    if (args._id == "MenuItem1") {
        displayString += "Selected Menu Item Text : " + $(args._currentItem).text() + " \n";
        displayString += "Selected Target Item Text : " + $(args._targetItem).text().trim() + " \n";
        $("#ContextItemDetails").val(displayString);
    }
    else if (args._id == "MenuItem2") {
        displayString += "Selected Menu Item Text : " + $(args._currentItem).text() + " \n";
        displayString += "Selected Target Item Text : " + $(args._targetItem).text().trim() + " \n";
        $("#ContextItemDetails").val(displayString);
    }
}



function ActionSuccess() {
    alert("Appointments Imported");
}

function ActionBegins(sender, args) {
    if (args._requestType == "Import") {
        $("#message").html($("#FileName").val() + " file is imported");
        $("#ClientImportWindow").addClass('clientAppointment');
        $(".ClientAppointment").css("visibility", "visible");
        args._data["FileName"] = $("#FileName").val();
        $("#ClientImportWindow").dialog("option", "modal", true);
        $("#message").val($("#FileName").val() + " file is imported");
        $("#ClientImportWindow").dialog("open");

    }

}