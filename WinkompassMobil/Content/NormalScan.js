/*var done = false;
$(function () {
    //$('#scanInput').keydown(function () {
    //    var UserInput = document.getElementById("mo");
    //    if (UserInput.checked === false && done!==true)
    //    {


    //    }
    //});
});*/
$("#TargetInput").bind("keypress", function (e) {
    if (e.keyCode === 13) {
        $("#scanInput").focus();
        return false;
    }
});
$("#scanInput").bind("keypress", function (e) {
    if (e.keyCode === 13) {
        $("#itemCount").focus();
        return false;
    }
});
$("#itemCount").bind("keypress", function (e) {
    
    var itemCount = $("#itemCount").val();
    itemCount = replace.itemCount(".", ",");
    $("#itemCount").val(itemCount);
    
});


$(window).load(function () {

    $("#scanInput").focus();

});