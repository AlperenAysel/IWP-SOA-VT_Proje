$(function () {
  var header = $("#mainNavigationBar");
  // var nav = $(".navbar #1");

  $(window).scroll(function () {
    var scroll = $(window).scrollTop();
    // nav.removeClass("active");
    if (scroll >= 50) {
      header.addClass("scrolled");
    } else {
      header.removeClass("scrolled");
    }
  });
});