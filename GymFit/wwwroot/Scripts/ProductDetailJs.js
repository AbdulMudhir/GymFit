

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


const cartSession = sessionStorage.getItem("cart");

    const cartTotal = document.querySelector(".cart-total");

    let currentCartTotal = parseInt(cartTotal.textContent);

    if (cartSession == "") {


        const product = {
            id: parseInt(productDetailId),
            productID: parseInt(productID),
            name: productName,
            size: sizeMenu,
            price: price,
            flavour: flavourMenu,
            quantity: 1,
        }


        cartTotal.textContent = currentCartTotal + 1;
     

        const cart = `[${JSON.stringify(product)}]`;

        sessionStorage.setItem("cart", cart);


    }
    else {

        const cart = JSON.parse(cartSession);

        let found = false;

        for (let i = 0; i < cart.length; i++) {


            //console.log(parseInt(productDetailId))

            if (cart[i].id === parseInt(productDetailId) &&
                cart[i].productID === parseInt(productID)) {
                found = true;
               
                cart[i].quantity += 1;
                break;
            }
            else {
                found = false
            }



        }

        if (!found) {
            const product = {
                id: parseInt(productDetailId),
                productID: parseInt(productID),
                name: productName,
                size: sizeMenu,
                price: price,
                flavour: flavourMenu,
                quantity: 1,
            }

            cart.push(product);

            if (currentCartTotal >= 10) {
                cartTotal.textContent = "10+";
            }
            else {

                cartTotal.textContent = currentCartTotal + 1;
            }
         

        }

     


        sessionStorage.setItem("cart", JSON.stringify(cart))
      



    }

    console.log(JSON.parse(sessionStorage.getItem("cart")));
    updateCartTotalPrice()
}