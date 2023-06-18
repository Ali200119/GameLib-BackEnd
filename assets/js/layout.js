"use strict"

// Search

let search = document.getElementById("search");
let body = document.querySelector("body");

document.querySelector("header .user-panel .search .open-close").addEventListener("click", function() {
    search.style.top = 0;
    body.style.overflow = "hidden";
});

document.querySelector("#search .close").addEventListener("click", function() {
    search.style.top = "-100%";
    body.style.overflow = "unset";
});



// User

document.querySelector("header .user-panel .user i").addEventListener("click", function() {
    let loginRegister = document.querySelector("header .user-panel .user .login-register");

    if (loginRegister.style.opacity == 0) {
        loginRegister.style.opacity = 1;
        loginRegister.style.pointerEvents = "unset";
    }

    else {
        loginRegister.style.opacity = 0;
        loginRegister.style.pointerEvents = "none";
    }
});

document.addEventListener("click", function(event) {
    let target = event.target;
    let loginRegisterParent = document.querySelector("header .user-panel .user");
    let loginRegister = document.querySelector("header .user-panel .user .login-register");

    if (target !== loginRegister && !loginRegisterParent.contains(target)) {
        loginRegister.style.opacity = 0;
        loginRegister.style.pointerEvents = "none";
    }
});