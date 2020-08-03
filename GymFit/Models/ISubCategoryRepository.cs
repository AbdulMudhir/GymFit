using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public interface ISubCategory
    {

        public IEnumerable<SubCategory> AllSubCategories { get; set; }
    }
}
