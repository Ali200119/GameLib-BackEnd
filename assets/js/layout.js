"use strict"

// Search

document.querySelector("header .user-panel .search .open-close").addEventListener("click", function() {
    let search = document.querySelector("header .user-panel .search .search-input");

    if (search.style.opacity == 0) {
        search.style.opacity = 1;
        search.style.pointerEvents = "unset";
    }

    else {
        search.style.opacity = 0;
        search.style.pointerEvents = "none";
    }
});

document.addEventListener("click", function(event) {
    let target = event.target;
    let searchParent = document.querySelector("header .user-panel .search");
    let search = document.querySelector("header .user-panel .search .search-input");

    if (target !== search && !searchParent.contains(target)) {
        search.style.opacity = 0;
        search.style.pointerEvents = "none";
    }
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