

const subButtons = document.querySelectorAll(".sub-prod-info");
removeButtons();

function updateInputButton() {
    const inputButton = document.querySelectorAll(".img-input");

    for (i = 0; i < inputButton.length; i++) {

        inputButton[i].addEventListener("change", (event) => {
            imgPreviewWindow = event.target.parentElement.querySelector(".img-container img");
            const imagesUploaded = event.target.files;
            console.log(imgPreviewWindow)
            imgPreviewWindow.setAttribute("src", URL.createObjectURL(imagesUploaded[0]));


        })
    }
}

updateInputButton()
const addAdditional = document.querySelector(".add-additional-product");

const secondaryContainer = document.querySelector(".secondary-form-container");

addAdditional.addEventListener("click", (event) => {
    event.preventDefault();
    const firstChildToClone = secondaryContainer.firstElementChild;
    const totalChild = secondaryContainer.childElementCount;

    const newNum = totalChild ;

    const secondaryChild = document.createElement("div")
    secondaryChild.setAttribute("class", "additionalInfo-container");

    const template = `


                <div class="form-group">
                    <div class="requiredStart">*</div>
                    <label for="ProductDetails_${newNum}__Price">Price</label>
                    <input type="text" data-val="true" data-val-number="The field Price must be a number." data-val-required="The price field is required" id="ProductDetails_${newNum}__Price" name="ProductDetails[${newNum}].Price" value="">
                    <span class="field-validation-valid" data-valmsg-for="ProductDetails[${newNum}].Price" data-valmsg-replace="true"></span>
                </div>


                <div class="form-group">
                    <label for="ProductDetails_${newNum}__PreviousPrice">Previous Price - Optional</label>
                    <input type="text" data-val="true" data-val-number="The field Previous Price - Optional must be a number." id="ProductDetails_${newNum}__PreviousPrice" name="ProductDetails[${newNum}].PreviousPrice" value="">
                    <span class="field-validation-valid" data-valmsg-for="ProductDetails[${newNum}].PreviousPrice" data-valmsg-replace="true"></span>
                </div>

                <div class="form-group">
                    <div class="requiredStart">*</div>
                    <label for="ProductDetails_${newNum}__Size">Size</label>
                    <input type="text" data-val="true" data-val-required="The size field is required" id="ProductDetails_${newNum}__Size" name="ProductDetails[${newNum}].Size" value="">
                    <span class="field-validation-valid" data-valmsg-for="ProductDetails[${newNum}].Size" data-valmsg-replace="true"></span>
                </div>

                <div class="form-group">
                    <label for="ProductDetails_${newNum}__Flavour">Flavour</label>
                    <input type="text" id="ProductDetails_${newNum}__Flavour" name="ProductDetails[${newNum}].Flavour" value="">
                    <span class="field-validation-valid" data-valmsg-for="ProductDetails[${newNum}].Flavour" data-valmsg-replace="true"></span>
                </div>
                <div class="form-group img-formgroup">
                    <div class="requiredStart imgstar">*</div>
                    <label for="ProductDetails_${newNum}__Images">Images</label>
                    <div class="img-section">
                        <div class="img-container"><img></div>

                        <input class="img-input" type="file" data-val="true" data-val-required="The image is required" id="ProductDetails_${newNum}__Images" name="ProductDetails[${newNum}].Images" accept="image/*">
                    </div>
                    <span class="field-validation-valid" data-valmsg-for="ProductDetails[${newNum}].Images" data-valmsg-replace="true"></span>
                </div>

                <div class="form-group img-formgroup">
                    <div class="requiredStart ">*</div>
                    <label for="ProductDetails_${newNum}__CategoryDetailId">Category</label>
                    <select class="categoryOptions" data-val="true" data-val-required="The Category field is required." id="ProductDetails_${newNum}__CategoryDetailId" name="ProductDetails[${newNum}].CategoryDetailId">

                            <option value="1">Clothings - Men</option>
                            <option value="2">Clothings - Women</option>
                            <option value="3">FootWears - Men</option>
                            <option value="4">FootWears - Women</option>
                            <option value="5">Equipments - Weights/Dumbbells</option>
                            <option value="6">Equipments - Fitness Equipment</option>
                            <option value="7">Suppliments - </option>


                    </select>
                    <span class="field-validation-valid" data-valmsg-for="ProductDetails[${newNum}].CategoryDetailId" data-valmsg-replace="true"></span>

                <button class="sub-prod-info"> Remove Above sub product info </button>

`
    secondaryChild.innerHTML = template;
    secondaryContainer.appendChild(secondaryChild);
    removeButtons();

    updateInputButton()

})

function removeButtons() {
    const removeButton = document.querySelectorAll(".sub-prod-info");

    for (let i = 0; i < removeButton.length; i++) {


        removeButton[i].addEventListener("click", (event) => {
            event.preventDefault();
            event.target.parentElement.parentElement.remove();
        })
    }
}