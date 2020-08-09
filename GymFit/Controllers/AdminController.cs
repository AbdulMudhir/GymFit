using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymFit.Models;
using GymFit.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymFit.Controllers
{
    public class AdminController : Controller
    {
        readonly IProductRepository _productRepository;

        public AdminController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var adminView = new AdminViewModel() {
                AllProducts = _productRepository.AllProducts
            };

            return View(adminView);
        }
    }
}
