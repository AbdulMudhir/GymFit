
function updateCartTotalPrice() {

    const cartTotalPrice = document.querySelector(".cart-total_price");



    const cartSession = JSON.parse(sessionStorage.getItem("cart"));
    let totalPrice = 0;


    for (let i = 0; i < cartSession.length; i++) {



        totalPrice += cartSession[i].price * cartSession[i].quantity;



    }
    cartTotalPrice.textContent = totalPrice;
}