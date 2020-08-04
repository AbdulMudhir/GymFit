using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public IEnumerable<CategoryDetail> CategoryDetails { get; set; }

    }
}
