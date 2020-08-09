using GymFit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.ViewModels
{
    public class CheckoutViewFormModel
    {
        [Required]
        public string Name { get; set; }

        [DisplayName("Line 1")]
        [Required]
        public string AddressLine1 { get; set; }

        [DisplayName("Line 2")]
        [Required]
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string Country { get; set; }

        public List<ShoppingCartItem> _shoppingCart { get; set; }
    }
}
