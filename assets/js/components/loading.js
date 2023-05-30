"use strict"

function loading() {
    let loading = setInterval(function() {
        clearInterval(loading);
        document.querySelector("#loading .title").classList.add("hide");
        document.querySelector("#loading .animation").classList.add("hide");

        document.querySelector("#loading").classList.add("deactivate");
    }, 2600);
}

loading();