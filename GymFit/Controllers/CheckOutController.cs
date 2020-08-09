using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymFit.Models;
using GymFit.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymFit.Controllers
{
    public class CheckOutController : Controller
    {

        private readonly ShoppingCart _shoppingCart;
        private readonly IOrderRepository _orderRepository;

        public CheckOutController(ShoppingCart shoppingCart, IOrderRepository orderRepository)
        {
            _shoppingCart = shoppingCart;
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            if(_shoppingCart != null)
            {
                var checkout = new CheckoutViewFormModel()
                {

                    _shoppingCart = _shoppingCart._shoppingCart
                };

                return View(checkout);
            }

            return RedirectToAction("index", "Home");
        }

        [HttpPost]
        public IActionResult Index(CheckoutViewFormModel form)
        {
           

            if(ModelState.IsValid)
            {
                return View();
            }


            return View(form);
        }
    }
}
