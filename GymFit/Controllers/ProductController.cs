using GymFit.BlobStorageServices;
using GymFit.Models;
using GymFit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Controllers
{
    public class ProductController:Controller
    {
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;

        private IBlobService _blobService;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IBlobService blobService)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _blobService = blobService;
        }

        public IActionResult Detail(int id)
        {

            var product = _productRepository.GetProductByID(id);

            if(product != null)
            {
                return View(product);
            }


            return NotFound() ;
        }

        public IActionResult Add()
        {
            var form = new AddProductFormVIewModel();

            var categoryDetail = _categoryRepository.AllCategoryDetails;

            foreach(var cd in categoryDetail)
            {
                form.CategoriesDetail.Add(

                    new SelectListItem { Value = cd.CategoryDetailId.ToString(), Text =$"{ cd.Category.Name } - {cd.SubCategory.Name}" }
                    );
            }



            return View(form);
        }

        public IActionResult Remove(int id)
        {
            var product = _productRepository.GetProductByID(id);

            if(product != null)
            {
                if(!product.IsFrontPageProduct)
                {
                    _productRepository.RemoveProduct(product);

                    return RedirectToAction("index", "Admin");

                }
            }


            return NotFound();
        }

        public IActionResult Edit(int id)
        {

            var product = _productRepository.GetProductByID(id);

            if (product != null)
            {
                var form = new AddProductFormVIewModel()
                {
                    Name = product.Name,
                    Safety = product.Safety,
                    ProductId = product.ProductId,
                    Ingredient = product.Ingredient,
                    Description = product.Description,
                    Brand = product.Brand,

                }

                    ;

                var categoryDetail = _categoryRepository.AllCategoryDetails;

                foreach (var cd in categoryDetail)
                {
                    form.CategoriesDetail.Add(

                        new SelectListItem { Value = cd.CategoryDetailId.ToString(), Text = $"{ cd.Category.Name } - {cd.SubCategory.Name}" }
                        );
                }


                var productDetails = new List<AddProductDetails>();


                foreach(var productDetail in product.ProductDetail)
                {
                    productDetails.Add(

                        new AddProductDetails()
                        {
                            Size= productDetail.Size,
                            Flavour = productDetail.Flavour,
                            ImageUrl = productDetail.Images.First().Url,
                            CategoryDetailId = productDetail.CategoryDetailId,
                            PreviousPrice = productDetail.PreviousPrice,
                            Price = productDetail.Price
                        }


                        );
                }

                form.ProductDetails = productDetails;

                return View(form);

            }

            return NotFound();
        }



       


        [HttpPost]
        public async Task<IActionResult> Edit(AddProductFormVIewModel form)
        {
            foreach (var product in form.ProductDetails)
            {
                if (product.PreviousPrice == null)
                {
                    product.PreviousPrice = product.Price;
                }



            }

            if (ModelState.IsValid)
            {

                var product = _productRepository.GetProductByID(form.ProductId);
                if (product != null)
                {


                    product.Name = form.Name;
                       product.Safety = form.Safety;
                        product.Ingredient = form.Ingredient;
                        product.Description = form.Description;
                        product.Brand = form.Brand;


                  

                    var productDetails = new List<ProductDetail>();

                    foreach (var produtDetail in form.ProductDetails)
                    {

                        var prod = new ProductDetail
                        {
                            Size = produtDetail.Size,
                            Flavour = produtDetail.Flavour,
                            CategoryDetailId = produtDetail.CategoryDetailId,
                            Price = (decimal)produtDetail.Price,
                            PreviousPrice = (decimal)produtDetail.PreviousPrice,


                        };



                        var uniqueFileName = Path.GetRandomFileName() + Path.GetExtension(produtDetail.Images.FileName);

                        var imgUrl = await _blobService.UploadFileBlobAsync(produtDetail.Images, uniqueFileName);

                        prod.Images = new List<Image> { new Image { Url = imgUrl } };

                        productDetails.Add(prod);
                    }

                    product.ProductDetail = productDetails;

                    _productRepository.UpdateProduct(product);

                    return RedirectToAction("index", "Admin");
                }

               
            }
            var categoryDetail = _categoryRepository.AllCategoryDetails;
            foreach (var cd in categoryDetail)
            {
                form.CategoriesDetail.Add(

                    new SelectListItem { Value = cd.CategoryDetailId.ToString(), Text = $"{ cd.Category.Name } - {cd.SubCategory.Name}" }
                    );
            }

            return View(form);
        }

            [HttpPost]
        public async Task<IActionResult> AddAsync( AddProductFormVIewModel form)
        {
            foreach(var product in form.ProductDetails)
            {
                if(product.PreviousPrice == null)
                {
                    product.PreviousPrice = product.Price;
                }



            }

            if(ModelState.IsValid)
            {
                var newProduct = new Product()
                {
                    Name = form.Name,
                    Safety = form.Safety,
                    Ingredient = form.Ingredient,
                    Description = form.Description,
                    Brand = form.Brand,
                

                };

                var productDetails = new List<ProductDetail>();

                foreach (var produtDetail in form.ProductDetails)
                {

                    var prod = new ProductDetail
                    {
                        Size = produtDetail.Size,
                        Flavour = produtDetail.Flavour,
                        CategoryDetailId = produtDetail.CategoryDetailId,
                        Price = (decimal)produtDetail.Price,
                        PreviousPrice = (decimal)produtDetail.PreviousPrice,
                       

                    };

                   

                    var uniqueFileName = Path.GetRandomFileName() + Path.GetExtension(produtDetail.Images.FileName);

                    var imgUrl = await _blobService.UploadFileBlobAsync(produtDetail.Images, uniqueFileName);

                    prod.Images = new List<Image> { new Image { Url = imgUrl} };

                    productDetails.Add(prod);
                }

                newProduct.ProductDetail = productDetails;

                _productRepository.AddProduct(newProduct);

                return RedirectToAction("index", "Admin");
            }


            var categoryDetail = _categoryRepository.AllCategoryDetails;
            foreach (var cd in categoryDetail)
            {
                form.CategoriesDetail.Add(

                    new SelectListItem { Value = cd.CategoryDetailId.ToString(), Text = $"{ cd.Category.Name } - {cd.SubCategory.Name}" }
                    );
            }

            



            return View(form);
        }
        [HttpPost]
        public async Task<IActionResult> SearchResult([FromBody] SearchModel search)
        {

            if (ModelState.IsValid)
            {


                var products = _productRepository.SearchProductByName(search.ProductName);


                if (products != null)
                {


                    return Json(new { success = "true", data = products });
                }

            }


            return Json(new { success = "false" });
        }
    }
}
