"use strict"

// Blog Background Parallax

let blogBG = document.querySelector("#blog-bg img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    blogBG.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});