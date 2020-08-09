using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymFit.Models;
using GymFit.ViewModels;
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
         

            var shoppingCartViewModel = new ShoppingCartViewModel { shoppingCartList = _shoppingCart._shoppingCart };

            return View(shoppingCartViewModel);
        }

        [HttpPost]
        public IActionResult addCart ([FromBody]ProductShoppingCartModel product)
        {

            _shoppingCart.AddShoppingCartItem(product);

            return Json( new { success = "true"});
        }

        public JsonResult CartInfo()
        {

            return Json(new { success = "true", 
                totalCost = _shoppingCart.totalCost(),
                total = _shoppingCart.totalCartItem()
            });
        }

        [HttpPost]
        public IActionResult amendQuantityCart([FromBody] ProductShoppingCartModel product)
        {

            _shoppingCart.AmendShoppingCartQuantity(product.ProductDetailId, product.Amount);

            return Json(new { success = "true" });
        }

        [HttpPost]
        public IActionResult removeCartItem([FromBody] ProductShoppingCartModel product)
        {

            _shoppingCart.RemoveShoppingCartItem(product.ProductDetailId);

            return Json(new { success = "true" });
        }

    }
}
