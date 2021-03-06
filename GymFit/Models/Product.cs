﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Safety { get; set; }
        public string Ingredient { get; set; }


        public string Description { get; set; }

        public string Brand { get; set; }

        public int ProductDetailId { get; set; }

        [JsonIgnore]
        public IEnumerable<ProductDetail> ProductDetail { get; set; }

        public bool IsFrontPageProduct { get; set; }

        public bool Sale { get; set; }
    }
}
