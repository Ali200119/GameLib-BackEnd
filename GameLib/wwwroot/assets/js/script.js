"use strict"

// Fav-Game Parallax

let favGameBG = document.querySelector("#fav-game img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    favGameBG.style.transform = `translateY(${scrollPosition * 0.4}px)`;
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



// Tab-Menu

let headers = document.querySelectorAll("#games .tab-menu-header ul li");
let items = document.querySelectorAll("#games .tab-menu-items .items");


for (const header of headers) {
    header.addEventListener("click", function() {
        document.querySelector("#games .tab-menu-header ul .active").classList.remove("active");
        this.classList.add("active");

        for (const item of items) {
            if (item.getAttribute("data-category") == this.getAttribute("data-category")) {
                item.style.opacity = 1;
                item.style.pointerEvents = "unset";
            }

            else {
                item.style.opacity = 0;
                item.style.pointerEvents = "none";
            }
        }
    });
}



// Developers Parallax

let developersBG = document.querySelector("#developers .bg");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    developersBG.style.transform = `translateY(${scrollPosition * 0.4 - 1000}px)`;
});



// Developers Slider

$(document).ready(function() {
    $("#developers .logos").slick({
        slidesToShow: 5,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 3000,
        arrows: false
    });
});