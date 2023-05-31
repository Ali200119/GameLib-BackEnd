"use strict"

// Fav-Game Parallax

let image = document.querySelector("#fav-game img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    image.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});



// Blog Slider

$(document).ready(function() {
    $("#blog .blog-items").slick({
        infinite: false,
        slidesToShow: 3,
        slidesToScroll: 1,
        prevArrow: '<i class="fa-solid fa-chevron-left prev"></i>',
        nextArrow: '<i class="fa-solid fa-chevron-right next"></i>'
    });
});