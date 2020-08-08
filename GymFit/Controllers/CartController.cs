using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymFit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymFit.Controllers
{
    public class CartController : Controller
    {

        private readonly ShoppingCart _shoppingCart;

        public CartController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public IActionResult addCart ([FromBody]ProductShoppingCartModel product)
        {

            _shoppingCart.AddShoppingCartItem(product);

            return Json( new { success = "true"});
        }

    }
}
