using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace GymFit.Models
{
    public class ShoppingCart
    {


        private readonly DatabaseContext _databaseContext;
        private readonly ISession _session;

        public ShoppingCart(ISession session, DatabaseContext databaseContext)
        {
            _session = session;
            _databaseContext = databaseContext;
        }



        public List<ShoppingCartItem> _shoppingCart 
        { 
            get { return JsonSerializer.Deserialize<List<ShoppingCartItem>>(_session.GetString("cart")); 
            } 
            set {


                _session.SetString("cart", JsonSerializer.Serialize(value)); 
            
            } 
        } 

        public void AddShoppingCartItem (ProductShoppingCartModel product)
        {
            var productFromDb = _databaseContext.ProductDetails.Where
                (p => p.ProductDetailId == product.ProductDetailId)
                .Include(p => p.Images).Include(p => p.Product).Include(p => p.CategoryDetail.Category).First();

            List<ShoppingCartItem> shoppingCartList;

            if (productFromDb != null)
            {
                var shoppingCartEnumerable = _shoppingCart.AsEnumerable();

                var itemExist = shoppingCartEnumerable.FirstOrDefault
                    (p => p.Product.ProductDetailId == product.ProductDetailId);


                if (itemExist != null)
                {
                    itemExist.Quantity++;

                    _shoppingCart = (List<ShoppingCartItem>)shoppingCartEnumerable;
                }
                else
                {
                  

                    productFromDb.ProductDetailId = product.ProductDetailId;

                    ShoppingCartItem productToAdd = new ShoppingCartItem()
                    { Product = productFromDb, Quantity = 1 };


                    shoppingCartList = shoppingCartEnumerable.ToList();

                     shoppingCartList.Add(productToAdd);

                    _shoppingCart = shoppingCartList;

                }


            }



        }


        public void AmendShoppingCartQuantity(int productDetailId, int amount)
        {
            


 
                var shoppingCartEnumerable = _shoppingCart.AsEnumerable();
                var itemExist = shoppingCartEnumerable.FirstOrDefault
                      (p => p.Product.ProductDetailId == productDetailId);


            if (itemExist != null)
                {
                itemExist.Quantity = amount;

                _shoppingCart = shoppingCartEnumerable.ToList(); 
                }
           
        }

        public decimal totalCost()
        {
            return _shoppingCart.AsEnumerable().Sum(p => p.Product.Price * p.Quantity);
        }

        public int totalCartItem()
        {
            return _shoppingCart.Count;
        }

        public static ShoppingCart createShoppingCart(IServiceProvider services)
        {
            var session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<DatabaseContext>();

            string shoppingCart = session.GetString("cart");

            if(shoppingCart == null)
            {
                session.SetString("cart", "[]");
            }

            return new ShoppingCart(session, context);
        }

    }
}
