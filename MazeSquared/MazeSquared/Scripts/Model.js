var activeSquare = function () {
    var addy = "api/GetStart";
    $.ajax({
        url: addy,
        method: 'GET',
        type:'json'
    }).done(function (activatedSquare) {
        console.log("that far");
            $('.' + activatedSquare).addClass('startActivated');
        });
}
var startSquare = function () {
    var addy = "api/GetStart";
    $.ajax({
        url: addy,
        Method:'GET'
    }).done(function (gettedStart) {
        $('div[id="' + gettedStart + '"]').css({ 'background-color': '#f5fffa' }); 
    });
}
var nextSquare = function () {
    $.get({
        url: "/api/GetNextSquare"
        }).done(function (gettedNextSquare) {
            $('div[id="' + gettedNextSquare + '"]').css({ 'background-color': '#fa8072' });
    });
}

