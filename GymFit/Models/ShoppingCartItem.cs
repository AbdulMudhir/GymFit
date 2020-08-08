using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class ShoppingCartItem
    {

        public ProductDetail Product { get; set; }

        public int Quantity { get; set; }

    }
}
