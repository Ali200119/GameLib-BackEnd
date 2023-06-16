"use strict"

// Clear Cart

document.querySelector("#devide #games .clear").addEventListener("click", function () {
    document.getElementById("games").style.display = "none";
    document.getElementById("checkout").style.display = "none";
    document.querySelector("#devide .empty").style.display = "unset";
});



// Remove Game From Cart

let removeBtn = document.querySelectorAll("#devide #games table tbody tr .name i");

for (const remove of removeBtn) {
    remove.addEventListener("click", function () {
        this.parentNode.parentNode.remove();

        if (document.querySelector("#devide #games table tbody").children.length == 0) {
            document.getElementById("games").style.display = "none";
            document.getElementById("checkout").style.display = "none";
            document.querySelector("#devide .empty").style.display = "unset";
        }


        subtotalAndTotal();
    });
}



// Subtotal and Total

subtotalAndTotal();





// Functions

function subtotalAndTotal() {
    let subtotal = document.querySelector("#devide #checkout .subtotal .price");
    let subtotalSum = 0;

    for (const price of document.querySelectorAll("#devide #games table tbody tr .price")) {
        subtotalSum += parseFloat(price.lastElementChild.innerText);
    }

    subtotal.lastElementChild.innerText = subtotalSum;



    let total = document.querySelector("#devide #checkout .total .price");
    let totalSum = 0;

    for (const price of document.querySelectorAll("#devide #games table tbody tr .price")) {
        totalSum += parseFloat(price.lastElementChild.innerText);
    }

    total.lastElementChild.innerText = totalSum;
}