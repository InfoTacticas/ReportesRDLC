$(document).ready(function () {
    

    /////////////////////////////////////////////
    // ACTIVAR MODULO
    (function ($) {
        $.gety = function (key) {
            key = key.replace(/[\[]/, '\\[');
            key = key.replace(/[\]]/, '\\]');
            var pattern = "[\\?&]" + key + "=([^&#]*)";
            var regex = new RegExp(pattern);
            var url = unescape(window.location.href);
            var results = regex.exec(url);
            if (results === null) {
                return null;
            } else {
                return results[1];
            }
        }
    })(jQuery);

    var parametro = $.gety("mod");
    if (parametro == null) {
        parametro = 1;
    }
    $("#" + parametro).addClass("active");

    ///////////////////////////////////////////////

    $("#menu li a").click(function () {
        
    });
});