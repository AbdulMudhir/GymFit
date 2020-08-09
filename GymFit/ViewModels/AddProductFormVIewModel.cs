using GymFit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.ViewModels
{
    public class AddProductFormVIewModel
    {

        [Required]
        public string Name { get; set; }

        public string Safety { get; set; }
        public string Ingredient { get; set; }


        public string Description { get; set; }

        public string Brand { get; set; }

        public List<AddProductDetails> ProductDetails { get; set; }

        public AddProductDetails ProductDetail { get; set; } 


    }
}
