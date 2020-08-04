using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class CategoryDetail
    {
        public int CategoryDetailId { get; set; }
      

        public int CategoryId { get; set; }

        public SubCategory SubCategory { get; set; }

        public int SubCategoryId { get; set; }
    }
}
