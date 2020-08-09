using GymFit.Models;
using GymFit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Controllers
{
    public class ProductController:Controller
    {
        IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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

            return View(form);
        }
    }
}
