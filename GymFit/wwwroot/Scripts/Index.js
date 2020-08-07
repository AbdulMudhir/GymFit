

const addToCartButtons = document.querySelectorAll(".card-cart-button");


for (let i = 0; i < addToCartButtons.length; i++) {


    addToCartButtons[i].addEventListener("click", addToCart)
}


function addToCart(event) {

    const parentContainer = event.target.parentElement
    const productID = parentContainer.attributes["id"].value;

    const sizeMenu = parentContainer.querySelector(".size-menu");

    const productDetailId = parentContainer.querySelector(".productDetailId").value;


    let price = parseFloat(parentContainer.querySelector(".price").textContent).toFixed(2);





    const product = {
        id: parseInt(productDetailId),
        productID: parseInt(productID),
        size: sizeMenu,
        price: price,
        quantity: 1,
    }


    addProductToCart(product)
    updateCartTotalPrice()
}