$(document).ready(function () {
    $("#submit").click(function () {
        var data = JSON.stringify({ "numbers": $("#input").val() });

        $.ajax({
            type: "POST",
            url: '/NPlusOne/GetDuplicates?numbers=' + $("#input").val(),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $("#output").text(data.outputValues);
            },
            error: function (data) {
                $("#output").text('Error');
            },
        });
    });
});