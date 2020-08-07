const cart = sessionStorage.getItem("cart");

if (cart == null) {

    sessionStorage.setItem("cart", "");
}