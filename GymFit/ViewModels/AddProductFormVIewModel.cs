using GymFit.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.ViewModels
{
    public class AddProductFormVIewModel
    {

        public int ProductId { get; set; }


        [Required]
        public string Name { get; set; }

        public string Safety { get; set; }
        public string Ingredient { get; set; }


        public string Description { get; set; }

        public string Brand { get; set; }

        public List<SelectListItem> CategoriesDetail { get; set; } = new List<SelectListItem>();


        public List<AddProductDetails> ProductDetails { get; set; } 

        public AddProductDetails ProductDetail { get; set; } 


    }
}
