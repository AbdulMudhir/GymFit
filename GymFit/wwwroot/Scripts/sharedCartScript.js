
function updateCartTotalPrice() {

    const ajax = new XMLHttpRequest();

    ajax.open("Get", "/Cart/CartInfo");
    ajax.responseType = "json";

    ajax.setRequestHeader("Content-Type", "application/json;charset=UTF-8")


    ajax.onload = function (e) {

        if (this.status === 200) {


            if (this.response.success === "true") {

                const cartPrice = document.querySelector(".cart-total_price");
                const cartTotal = document.querySelector(".cart-total");

                if (this.response.total >= 5) {
                    cartTotal.textContent = "5+";

                }
                else {
                    cartTotal.textContent = this.response.total;
                } 
                cartPrice.textContent = parseFloat(this.response.totalCost).toFixed(2);
            }

        }
    }


    ajax.send()
}



function addProductToCart(product) {



    const cartSession = sessionStorage.getItem("cart");

    const cartTotal = document.querySelector(".cart-total");


    const ajax = new XMLHttpRequest();

    ajax.open("POST", "/Cart/addCart");
    ajax.responseType = "json";

    ajax.setRequestHeader("Content-Type", "application/json;charset=UTF-8")


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