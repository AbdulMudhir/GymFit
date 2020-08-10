

const quantityInput = document.querySelectorAll(".quantityInput");
const removeButton = document.querySelectorAll(".remove-cart-item");


for (let i = 0; i < quantityInput.length; i++) {


    removeButton[i].addEventListener("click", (event) => {

        const parentContainer = event.target.parentElement.parentElement;

        removeItem(event);

        console.log(parentContainer)


    })


    quantityInput[i].addEventListener("focusout", (event) =>{

        const numberTyped = event.target.value;


        if (numberTyped <= 0) {

            event.target.value = 1;
            alert("Can't have negative number")
        }


        const parentContainer = event.target.parentElement.parentElement;
        const priceContainer = parentContainer.querySelector(".current-price-cart");
        const totalPriceContainer = parentContainer.querySelector(".total-price-cart");


        const price = priceContainer.textContent.replace("£", "");

        const calculatePrice = price * event.target.value;


        totalPriceContainer.textContent = `£${calculatePrice.toFixed(2)}`;
        

        updateQuantity(event);

    });
}




function removeItem(event) {

    const parentContainer = event.target.parentElement.parentElement;
    const productDetailId = parentContainer.attributes["id"].value;

    console.log(productDetailId)
    const ajax = new XMLHttpRequest();

    ajax.open("POST", "/Cart/removeCartItem");
    ajax.responseType = "json";

    ajax.setRequestHeader("Content-Type", "application/json;charset=UTF-8")

    const product = {
        ProductDetailId: productDetailId,
    }


    ajax.onload = function (e) {

        if (this.status === 200) {


            if (this.response.success === "true") {
                parentContainer.remove();

                const totalRowsLeft = document.querySelectorAll(".row").length;

                if (totalRowsLeft == 0) {

                    document.querySelector(".checkoutbutton-container").style.display = "none";
                }


                updateCartTotalPrice()
            }

        }
        else {

            alert("issue with server cart will not be avaible at the moment please try again next minute")
        }

    }


    ajax.send(JSON.stringify(product))

}



function updateQuantity(event) {
    const parentContainer = event.target.parentElement.parentElement;
    const productDetailId = parentContainer.attributes["id"].value;

    const numberTyped = parseInt(event.target.value);

    const ajax = new XMLHttpRequest();

    ajax.open("POST", "/Cart/amendQuantityCart");
    ajax.responseType = "json";

    ajax.setRequestHeader("Content-Type", "application/json;charset=UTF-8")

    const product = {
        ProductDetailId : productDetailId,
        Amount: numberTyped
    }


    ajax.onload = function (e) {

        if (this.status === 200) {


            if (this.response.success === "true") {
                updateCartTotalPrice()
            }

        }
        else {

            alert("issue with server cart will not be avaible at the moment please try again next minute")
        }

    }


    ajax.send(JSON.stringify(product))

}