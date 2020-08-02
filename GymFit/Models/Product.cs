using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public Decimal Price { get; set; }
        public Decimal PreviousPrice { get; set; }
        public string Safety { get; set; }
        public string Ingredient { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public  IEnumerable<Image>  Images{ get; set; }

        public bool Sale { get; set; }
    }
}
