using GymFit.Models;
using GymFit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Controllers
{
    public class CatalogueController:Controller
    {

        private readonly IProductRepository _productRepository;

        public CatalogueController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ActionName("subcategory")]
        public IActionResult Index(int subcategoryId, int categoryId)
        {

       


            CatalogueViewModel catalogueViewModel = new CatalogueViewModel();

            catalogueViewModel.Products = _productRepository.GetProductsBySubCategory(categoryId, subcategoryId);

            return View("Index", catalogueViewModel);
        }

        [ActionName("category")]
        public IActionResult Index(int categoryId)
        {
            CatalogueViewModel catalogueViewModel = new CatalogueViewModel();
            catalogueViewModel.Products = _productRepository.GetProductsByCategoryId(categoryId);

   


            return View("Index", catalogueViewModel);
        }
    }
}
