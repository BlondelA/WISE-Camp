jQuery(document).ready(function ($) {

    $(".wise-input").focus(function(){
        $(this).parent().addClass("active");
    });
     $(".wise-input").focusout(function(){
        $(this).parent().removeClass("active");
    });
});