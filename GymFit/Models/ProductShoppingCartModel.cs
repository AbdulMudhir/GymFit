﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class ProductShoppingCartModel
    {

      
        public int ProductDetailId { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public int Amount { get; set; }

    }
}
