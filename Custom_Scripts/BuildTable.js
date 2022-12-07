$(document).ready(function (){
    $.ajax({
        /* to send a request to this url */
        url: '/ToDoes/BuildToDoTable',
        /* what to do in case of success - to change the tableDiv id from Index.cshtml */
        success: function (result){
            $('#tableDiv').html(result);
        }
    });
});