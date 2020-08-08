

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

cartButton.addEventListener("click", addToCart);

function addToCart(event) {

    const parentContainer = event.target.parentElement
    const productID = parentContainer.attributes["id"].value;
    const productName = parentContainer.querySelector(".product-name h1").textContent;
    const sizeMenu = parentContainer.querySelector(".size-menu");
    const flavourMenu = parentContainer.querySelector(".Flavour-menu").value;

    const productDetailId = sizeMenu.value;

  

    let price = 0;

   
    const priceContainer = document.querySelector(".price-container");
    
    for (let i = 0; i  < priceContainer.children.length ; i++) {

        let priceSelector = priceContainer.children[i];
        if (window.getComputedStyle(priceSelector).display != "none")
        {
            price = parseFloat(priceSelector.querySelector(".price").textContent);
        }
    }

    const product = {
        ProductDetailId: parseInt(productDetailId),
        productID: parseInt(productID),
        flavour: flavourMenu,
        quantity: 1,
    }

    addProductToCart(product)
   
}