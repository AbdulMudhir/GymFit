

const cardCartButtons = document.querySelectorAll(".card-cart-button");


for (let i = 0; i < cardCartButtons.length; i++) {

    cardCartButtons[i].addEventListener("click", (event) => {

        const productDetailId = event.target.parentElement.querySelector(".productDetailId").value;

        const product = {
            ProductDetailId: parseInt(productDetailId)


        }
        addProductToCart(product);

    })
}


