"use strict"

// Blog Background Parallax

let blogBG = document.querySelector("#blog-bg img");

window.addEventListener("scroll", function() {
    let scrollPosition = window.pageYOffset;

    blogBG.style.transform = `translateY(${scrollPosition * 0.4}px)`;
});



//Search

document.querySelector("#panel .search .search-input i").addEventListener("click", function () {
    search();
});

document.querySelector("#panel .search .search-input input").addEventListener("keydown", function (event) {
    if (event.keyCode === 13) {
        search();
    }
});



// Delete Comment

let removeCommentBtns = document.querySelectorAll("#blog-content .comments .items .item i");

for (const remove of removeCommentBtns) {
    remove.addEventListener("click", function() {
        this.parentNode.remove();
    });
}




// Functions

function search() {
    let searchText = document.querySelector("#panel .search .search-input input");

    if (searchText.value.trim() != "") {
        window.location.assign(`/Search/SearchByBlogs?searchText=${searchText.value}`);
    }
}