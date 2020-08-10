using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.ViewModels
{
    public class AddProductDetails
    {


        public int StockAmount { get; set; }


        [Required(ErrorMessage ="The size field is required")]
        public string Size { get; set; }

        public string Flavour { get; set; }

        public int Weights { get; set; }

        [DisplayName("Image")]
        [DataType(DataType.Upload)]
        [Required(ErrorMessage ="The image is required")]
        public IFormFile Images { get; set; }




        [DisplayName("Category")]
        public int CategoryDetailId { get; set; }


        [DataType(DataType.Currency, ErrorMessage = "The Price is not a valid format")]
        [Required(ErrorMessage = "The price field is required")]
        public Decimal? Price { get; set; }

        [DisplayName("Previous Price - Optional")]
        [DataType(DataType.Currency, ErrorMessage = "The price is not a valid format")]
        public Decimal? PreviousPrice { get; set; }
    }
}
