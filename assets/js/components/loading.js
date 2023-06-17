"use strict"

setInterval(function() {
    clearInterval();
    document.querySelector("#loading .title").classList.add("hide");
    document.querySelector("#loading .animation").classList.add("hide");

    document.querySelector("#loading").classList.add("deactivate");
}, 2600);