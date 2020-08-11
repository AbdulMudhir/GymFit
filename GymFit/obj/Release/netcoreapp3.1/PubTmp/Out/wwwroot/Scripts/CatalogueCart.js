const cartButton = document.querySelectorAll(".add-to-cart-button");


for (let i = 0; i < cartButton.length; i++) {
    cartButton[i].addEventListener("click", (event) => {

        const productDetailId = event.target.parentElement.querySelector(".productDetailId").value;

        const product = {
            ProductDetailId: parseInt(productDetailId)


        }
        addProductToCart(product);

    })
}





