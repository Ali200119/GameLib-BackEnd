"use strict"

// Fav-Blog Parallax

let favBlogBG = document.querySelector("#fav-blog img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    favBlogBG.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});