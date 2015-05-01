$(document).ready(
    function() {
        var activeSquare = function() {
            $.get({
                url: "api/GetActiveSquare"
                }).done(function(activatedSquare) {
                        $('.' + activatedSquare).addClass('startActivated');
                });
        }
        var startSquare = function() {
            $.get({
                url: "api/GetStart"
            }).done(function(gettedStart) {
                $('.' + gettedStart).addClass('activated');
            });
        
        }

        var nextSquare = function () {
            $.get({
                url: "api/GetNextSquare"
            }).done(function (gettedNextSquare) {
                $('.' + gettedNextSquare).addClass('nextSquare');
            });

        }
    })
 