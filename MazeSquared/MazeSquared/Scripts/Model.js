var secondSquare = function () {
    var addy = "api/Get2ndSquare";
    $.ajax({
        url: addy,
        Method: 'GET',
    }).done(function (Get2ndSquare) {
        $('.' + Get2ndSquare).addClass('activated').removeClass('deNada');;
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
var getActiveSqaure = function () {
    $.ajax({
        url: "/api/WhereWeAtNow",
        Method: 'GET'
    }).done(function(resultantLocal) {
        $('div[id="'+resultantLocal+'"]').addClass('startActivated').removeClass('deNada');
        console.log(resultantLocal ="yup!")
    });

}