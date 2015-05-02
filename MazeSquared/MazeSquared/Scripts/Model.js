var activeSquare = function () {
    var addy = "api/GetActiveSquare";
    $.ajax({
        url: addy,
        Method: 'GET',
    }).done(function (activatedSquare) {
        $('.' + activatedSquare).addClass('activated').removeClass('deNada');;
        });
}
var startSquare = function () {
    var addy = "api/GetStart";
    $.ajax({
        url: addy,
        Method:'GET'
    }).done(function (gettedStart) {
        $('div[id="' + gettedStart + '"]').addClass('startActivated').removeClass('deNada');
        console.log(gettedStart + "yo!");
    });
}
var nextSquare = function () {
    $.ajax({
        url: "/api/GetNextSquare",
        Method:'GET'
        }).done(function (gettedNextSquare) {
            $('div[id="' + gettedNextSquare + '"]').addClass('nextedSquare').removeClass('deNada');;
    });
}

