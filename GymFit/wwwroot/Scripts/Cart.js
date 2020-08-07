const cart = sessionStorage.getItem("cart");

if (cart == null) {

    sessionStorage.setItem("cart", "");
}
else if (cart != "") {

    const cartSession = JSON.parse(sessionStorage.getItem("cart"));


    if (cartSession.length >= 10) {
        document.querySelector(".cart-total").textContent = "10+";
    }
    else {
        document.querySelector(".cart-total").textContent = cartSession.length;
    }

   
    updateCartTotalPrice()

}

