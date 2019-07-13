$(document).ready(function () {
    $('#results').hide();

    $("#submit").click(function () {
        var nVowels = 2;
        var nWords = 3;
        var nLines = 2;
        var cLines = 0;
        var cWords = 0;

        var lines = $('#input').val().toUpperCase().split('\n');
        $.each(lines, function (index, line) {
            if (line.length > 0 && ((index + 1) % nLines) == 0) {
                debugger;
                var lWords = line.trim().split(' ');
                var run = 0;
                $.each(lWords, function (index, word) {
                    if (((index + 1) % nWords) == 0 && vowelCount(word.trim()) >= nVowels) {
                        cWords++;
                        if (run == 0) {
                            cLines++;
                            run = 1;
                        }
                    }
                });
            }
        });

        $("#lines").text(cLines);
        $("#words").text(cWords);
        $('#results').show();
    });
});

function vowelCount(word) {
    var vowelsCount = 0
    word.split('').forEach(function (v) {
        if (v == 'A' || v == 'E' || v == 'I' || v == 'O' || v == 'U') {
            vowelsCount++;
        }
    });
    return vowelsCount;
}