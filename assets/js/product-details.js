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



// Add to Cart

document.querySelector("#cover-key-art-options #key-art-options .options button").addEventListener("click", function () {
    let alert = document.getElementById("game-added-alert");

    alert.innerText = `${this.parentNode.parentNode.firstElementChild.innerText} has been added to the cart`;
    alert.style.opacity = 1;
    alert.style.pointerEvents = "unset";

    setTimeout(function () {
        alert.style.opacity = 0;
        alert.style.pointerEvents = "none";
    }, 3000);
});



// Full Screen Screenshot

let screenshots = document.querySelectorAll("#visuals .screenshots .screenshot");

for (const screenshot of screenshots) {
    screenshot.addEventListener("click", function () {
        document.getElementById("full-screen").style.display = "flex";
        document.querySelector("body").style.overflow = "hidden";

        let image = this.firstElementChild.getAttribute("src");
        document.querySelector("#full-screen .image img").setAttribute("src", image);
    });
}

document.querySelector("#full-screen i").addEventListener("click", function () {
    document.getElementById("full-screen").style.display = "none";
    document.querySelector("body").style.overflow = "unset";

    document.querySelector("#full-screen .image img").removeAttribute("src");
});



// Countdown

if (document.getElementById("countdown").lastElementChild.classList.contains("time")) {
    let days = document.querySelector("#countdown .time .days span");
    let hours = document.querySelector("#countdown .time .hours span");
    let minutes = document.querySelector("#countdown .time .minutes span");
    let seconds = document.querySelector("#countdown .time .seconds span");
    let releaseDate = document.querySelector("#countdown .time");

    let endTime = new Date(`${releaseDate.getAttribute("data-day")} ${releaseDate.getAttribute("data-month")} ${releaseDate.getAttribute("data-year")} 00:00:00`)

    function updateCountdownTime() {
        let currentTime = new Date();
        let diff = endTime - currentTime;
        let day = Math.floor(diff / 1000 / 60 / 60 / 24);
        let hour = Math.floor(diff / 1000 / 60 / 60) % 24;
        let min = Math.floor(diff / 1000 / 60) % 60;
        let sec = Math.floor(diff / 1000) % 60;
        days.innerHTML = day < 10 ? `0` + day : day;
        hours.innerHTML = hour < 10 ? `0` + hour : hour;
        minutes.innerHTML = min < 10 ? `0` + min : min;
        seconds.innerHTML = sec < 10 ? `0` + sec : sec;
    }

    setInterval(updateCountdownTime, 1000);
}



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

    if (scrollPosition > 1800) {
        appearance(document.getElementById("comments"));
    }
});



// Delete Comment

let removeCommentBtns = document.querySelectorAll("#comments .items .item i");

for (const remove of removeCommentBtns) {
    remove.addEventListener("click", function () {
        this.parentNode.remove();
    });
}




// Functions

function appearance(element) {
    element.style.transform = "unset";
    element.style.opacity = 1;
    element.style.pointerEvents = "unset";
}