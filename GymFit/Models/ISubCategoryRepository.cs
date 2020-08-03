using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public interface ISubCategoryRepository
    {

        public IEnumerable<SubCategory> AllSubCategories { get; }
    }
}
