
Sys.Application.add_load(function () {    
    $("select#Skins").val($("#DefaultSkin").val());
    $("select#Skins").bind('change', function () {
        window.location.hash = "";
        var location = window.location.href.replace("#", "");
        window.location = replaceQueryString(location, "Skins", this.value);
    });
});