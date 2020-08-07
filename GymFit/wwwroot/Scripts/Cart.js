const cart = sessionStorage.getItem("cart");

if (cart == null) {

    sessionStorage.setItem("cart", "");
}
else if (cart != "") {

   
   
    updateCartTotalPrice()

}

