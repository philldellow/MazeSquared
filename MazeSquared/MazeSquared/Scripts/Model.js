﻿var startSquare = function () {
    var addy = "api/GetStart";
    $.ajax({
        url: addy,
        Method:'GET'
    }).done(function (gettedStart) {
        $('div[id="' + gettedStart + '"]').addClass('startActivated').removeClass('deNada');
        console.log(gettedStart + "yo!");
    });
}
var secondSquare = function () {
    var secondAddy = "api/Get2ndSquare";
    $.ajax({
        url: secondAddy,
        Method: 'GET',
    }).done(function (Get2ndSquare) {
        $('div[id="' + Get2ndSquare + '"]').addClass('startActivated').removeClass('deNada');
        console.log(gettedStart + "an dis yo!");
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
var getActiveSqaure = function () {
    $.ajax({
        url: "/api/WhereWeAtNow",
        Method: 'GET'
    }).done(function(resultantLocal) {
        $('div[id="'+resultantLocal+'"]').addClass('startActivated').removeClass('deNada');
        console.log(resultantLocal ="yup!")
    });

}