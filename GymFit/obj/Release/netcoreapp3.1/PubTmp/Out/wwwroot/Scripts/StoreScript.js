

const storeButton = document.querySelector(".store-button");

const categoryNavigation = document.querySelector(".navigation-category");


storeButton.addEventListener("pointerover", (event) => {

    categoryNavigation.style.display = "flex";

})

categoryNavigation.addEventListener("mouseleave", (event) => {

    
   categoryNavigation.style.display = "none";

})

