$(document).ready(function () {
    //hijack the html and make a board
    var linelimit = 65;
    $('body').empty();
    $('body').append("<div class = 'gameBoard'></div>");
    for (i = 1; i < linelimit; i++) {
        $('.gameBoard').append("<div class ='tile' id=" + '"' + i + '"' + '></div>');
        if (i % 8 == 0) {
            $('.gameBoard').append("</br>");
        }
    }
    //Jsons to css style the divs - will have to live here out of messysiticy for now
    $('.gameBoard').css({
        'background-color': '#6EBDBF',
        'height': '66%', 'width': '66%', 'border':'3px solid black', 'display':'block','margin-left':'auto', 'margin-right':'auto', 'text-align':'center', 'padding-top':'50px', 'padding-bottom':'50px', 
    })
    $('.tile').css({ 'height': '40px', 'width': '40px', 'border': '1px solid black', 'display': 'inline-block', 'margin-left': '7px', 'background-color': '#A0DAE5' })
    $('.startActivated').css({ 'background-color': '#f5fffa' });
    $('.activated').css({ 'background-color': '#f5fffa' });
    $('.nextSquare').css({ 'background-color': '#fa8072' });
    //see if we can get the first square to pop up before bedtime
   
    startSquare();
   
  
    //Action changing class on enter and leave
    $(".tile").mouseenter(function () {
        $(this).css({ 'background-color': '#E2FFFF' });
    });
    $('.tile').mouseleave(function () {
        $(this).css({ 'background-color': '#1E4035' })
    });

  
});

          
    
