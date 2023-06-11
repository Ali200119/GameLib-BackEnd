"use strict"

// Blog Background Parallax

let blogBG = document.querySelector("#blog-bg img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    blogBG.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});



// Delete Comment

let removeBtns = document.querySelectorAll("#blog-content .comments .items .item i");

for (const remove of removeBtns) {
    remove.addEventListener("click", function() {
        this.parentNode.remove();
    });
}