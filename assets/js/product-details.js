"use strict"

// Header

window.addEventListener("scroll", function () {
    let scrollPosition = pageYOffset;

    console.log(scrollPosition);

    if (scrollPosition > 156) {
        document.querySelector("header").style.backgroundColor = "#242230";
        document.querySelector("header").style.backdropFilter = "unset";
    }

    else {
        document.querySelector("header").style.backgroundColor = "transparent";
        document.querySelector("header").style.backdropFilter = "blur(3px)";
    }
});



// Cover Parallax

let cover = document.querySelector("#cover img");

window.addEventListener("scroll", function () {
    let scrollPosition = window.pageYOffset;

    cover.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});



// Full Screen Screenshot

let screenshots = document.querySelectorAll("#visuals .screenshots .screenshot");

for (const screenshot of screenshots) {
    screenshot.addEventListener("click", function () {
        document.getElementById("full-screen").style.opacity = 1;
        document.getElementById("full-screen").style.pointerEvents = "unset";
        document.querySelector("body").style.overflow = "hidden";

        let image = this.firstElementChild.getAttribute("src");
        document.querySelector("#full-screen .image img").setAttribute("src", image);
    });
}

document.querySelector("#full-screen i").addEventListener("click", function () {
    document.getElementById("full-screen").style.opacity = 0;
    document.getElementById("full-screen").style.pointerEvents = "none";
    document.querySelector("body").style.overflow = "unset";

    document.querySelector("#full-screen .image img").removeAttribute("src");
});



// Appearance Effect

appearance(document.getElementById("key-art-options"));
setInterval(function () {
    clearInterval();
    appearance(document.getElementById("about-info"));
}, 1000);

window.addEventListener("scroll", function () {
    let scrollPosition = window.pageYOffset;

    if (scrollPosition > 265) {
        appearance(document.getElementById("visuals"));
    }
});




// Functions

function appearance(element) {
    element.style.transform = "unset";
    element.style.opacity = 1;
    element.style.pointerEvents = "unset";
}