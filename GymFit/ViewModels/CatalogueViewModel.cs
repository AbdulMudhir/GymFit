using GymFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.ViewModels
{
    public class CatalogueViewModel
    {

       public  IEnumerable<ProductDetail> Products { get; set; }

        public Category Category { get; set; }
    }
}
