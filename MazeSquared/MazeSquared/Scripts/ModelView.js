$(document).ready(function () {
    //hijack the html and make a board
    var linelimit = 65;
    $('body').empty();
    $('body').append("<div class = 'gameBoard'></div>");
    for (i = 1; i < linelimit; i++) {
        $('.gameBoard').append("<div class ='tile deNada' id=" + '"' + i + '"' + '></div>');
        if (i % 8 == 0) {
            $('.gameBoard').append("</br>");
        }
    }

    $.when(startSquare()).done(function () { secondSquare(); });
   
    //Action changing class on enter and leave
    $('.deNada').mouseenter(function() {
        $(this).addClass("wrongSquare").removeClass('deNada');
    });

    $('.tile').mouseleave(function () {
        $(this).css({ 'background-color': '#1E4035' })
    });

  
});

          
    
