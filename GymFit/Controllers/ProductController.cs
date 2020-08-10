using GymFit.Models;
using GymFit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Controllers
{
    public class ProductController:Controller
    {
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
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
        [HttpPost]
        public IActionResult Add( AddProductFormVIewModel form)
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

                };
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
    }
}
