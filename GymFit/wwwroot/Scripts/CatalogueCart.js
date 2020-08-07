

const addToCartButtons = document.querySelectorAll(".add-to-cart-button");


for (let i = 0; i < addToCartButtons.length; i++) {


    addToCartButtons[i].addEventListener("click", addToCart)
}


function addToCart(event) {

    const parentContainer = event.target.parentElement
    const productID = parentContainer.attributes["id"].value;


    const productName = parentContainer.querySelector(".productName h4").textContent;
    const sizeMenu = parentContainer.querySelector(".size-menu");
    const flavourMenu = parentContainer.querySelector(".Flavour-menu").value;

    const productDetailId = parentContainer.querySelector(".productDetailId").value;

    
    let price = parseFloat(parentContainer.querySelector(".price").textContent).toFixed(2);





    const product = {
        id: parseInt(productDetailId),
        productID: parseInt(productID),
        name: productName,
        size: sizeMenu,
        price: price,
        flavour: flavourMenu,
        quantity: 1,
    }

    
    addProductToCart(product)
    updateCartTotalPrice()
}