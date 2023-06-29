"use strict"

// Increase Count

let increaseCountBtns = document.querySelectorAll("#devide #games table tbody tr .count .increase");

for (const increase of increaseCountBtns) {
    increase.addEventListener("click", function () {
        this.previousElementSibling.innerText++;

        subtotal();
        total();
    });
}



// Decrease Count

let decreaseCountBtns = document.querySelectorAll("#devide #games table tbody tr .count .decrease");

for (const decrease of decreaseCountBtns) {
    decrease.addEventListener("click", function () {
        if (parseInt(this.nextElementSibling.innerText) > 1) {
            this.nextElementSibling.innerText--;

            subtotal();
            total();
        }

        else {
            this.parentNode.parentNode.parentNode.remove();
            total();

            if(document.querySelector("#devide #games table tbody").children.length == 0) {
                clearCart();
            }
        }
    });
}



// Clear Cart

document.querySelector("#devide #games .clear").addEventListener("click", function () {
    clearCart();
});



// Remove Game From Cart

let removeBtn = document.querySelectorAll("#devide #games table tbody tr .name i");

for (const remove of removeBtn) {
    remove.addEventListener("click", function () {
        this.parentNode.parentNode.remove();

        if (document.querySelector("#devide #games table tbody").children.length == 0) {
            clearCart();
        }


        total();
    });
}



// Subtotal

subtotal();



// Total

total();





// Functions

function total() {
    let total = document.querySelector("#devide #checkout .total .price");
    let totalSum = 0;

    for (const price of document.querySelectorAll("#devide #games table tbody tr .subtotal :last-child")) {
        totalSum += parseFloat(price.innerText);
    }

    total.lastElementChild.innerText = totalSum;
}

function subtotal() {
    let subtotal = document.querySelectorAll("#devide #games table tbody tr .subtotal :last-child");

    for (const item of subtotal) {
        item.innerText = parseFloat(item.parentNode.previousElementSibling.previousElementSibling.lastElementChild.innerText) * parseInt(item.parentNode.previousElementSibling.firstElementChild.children[1].innerText);
    }
}

function clearCart() {
    document.getElementById("games").style.display = "none";
    document.getElementById("checkout").style.display = "none";
    document.querySelector("#devide .empty").style.display = "unset";
}