
function updateCartTotalPrice() {

    const cartTotalPrice = document.querySelector(".cart-total_price");



    const cartSession = JSON.parse(sessionStorage.getItem("cart"));
    let totalPrice = 0;

    console.log(cartSession)

    for (let i = 0; i < cartSession.length; i++) {



        totalPrice += cartSession[i].price * cartSession[i].quantity;

        console


    }
    cartTotalPrice.textContent = totalPrice.toFixed(2);


    if (cartSession.length >= 5) {
        document.querySelector(".cart-total").textContent = "5+";
    }
    else {
        document.querySelector(".cart-total").textContent = cartSession.length;
    }

}

function addProductToCart(product) {



    const cartSession = sessionStorage.getItem("cart");

    const cartTotal = document.querySelector(".cart-total");


    const ajax = new XMLHttpRequest();

    ajax.open("POST", "/Cart/addCart");
    ajax.responseType = "json";

    ajax.setRequestHeader("Content-Type", "application/json;charset=UTF-8")


    ajax.onload = function (e) {

        console.log(this.response)

    }


    ajax.send(JSON.stringify(product))

    //if (cartSession == "") {


        

    //    //cartTotal.textContent = currentCartTotal + 1;


    //    const cart = `[${JSON.stringify(product)}]`;

    //    sessionStorage.setItem("cart", cart);


    //}
    //else {

    //    const cart = JSON.parse(cartSession);

    //    let found = false;

    //    for (let i = 0; i < cart.length; i++) {



    //        if (cart[i].id === parseInt(product.id) &&
    //            cart[i].productID === parseInt(product.productID)) {
    //            found = true;
    //            cart[i].quantity += 1;
    //            break;
    //        }
    //        else {
    //            found = false
    //        }



    //    }

    //    if (!found) {
          

    //        cart.push(product);

           


    //    }




    //    sessionStorage.setItem("cart", JSON.stringify(cart))

     


    //}
    //updateCartTotalPrice()
}