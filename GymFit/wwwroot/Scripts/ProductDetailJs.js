

const sizeMenuButton = document.querySelector(".size-menu");

const imageContainer = document.querySelector(".product-detail-img-container");

const priceContainer = document.querySelector(".price-container");

sizeMenuButton.addEventListener("change", (event) => {
    const selectedIndex = event.target.selectedIndex;

    const imgs = imageContainer.querySelectorAll(".detail-img");
    const priceProduct = priceContainer.querySelectorAll(".product-price");

    for (let i = 0; i < imgs.length; i++) {
        imgs[i].style.display = "none";
        priceProduct[i].style.display = "none";
    }

    priceContainer.children[selectedIndex].style.display = "flex";
    imageContainer.children[selectedIndex].style.display = "block";

})

const backButton = document.querySelector(".back-container");
backButton.addEventListener("click", (event) => {

    window.history.back();


})

const cartButton = document.querySelector(".add-to-cart-button");

cartButton.addEventListener("click", (event) => {

    const selectMenu = document.querySelector(".prod-select");


    const product = {
        ProductDetailId: parseInt(selectMenu.value)


    }
    addProductToCart(product);
}
  
);

