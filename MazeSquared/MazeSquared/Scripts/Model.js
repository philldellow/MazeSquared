var activeSquare = function () {
    var addy = "api/GetActiveSquare";
    $.ajax({
        url: addy,
        Method: 'GET',
    }).done(function (activatedSquare) {
        $('.' + activatedSquare).css({ 'background-color': '#f5fffa' }).addClass('Activated').removeClass('deNada');;
        });
}
var startSquare = function () {
    var addy = "api/GetStart";
    $.ajax({
        url: addy,
        Method:'GET'
    }).done(function (gettedStart) {
        $('div[id="' + gettedStart + '"]').addClass('startActivated').removeClass('deNada').css({ 'background-color': 'pink' });
        console.log(gettedStart + "yo!");
    });
}
var nextSquare = function () {
    $.ajax({
        url: "/api/GetNextSquare",
        Method:'GET'
        }).done(function (gettedNextSquare) {
            $('div[id="' + gettedNextSquare + '"]').css({ 'background-color': '#fa8072' }).addClass('nextedSquare').removeClass('deNada');;
    });
}

