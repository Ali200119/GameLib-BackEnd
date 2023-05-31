"use strict"

// Parallax

let image = document.querySelector("#fav-game img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    image.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});