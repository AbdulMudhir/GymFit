using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public interface ICategoryRepository
    {

        public IEnumerable<Category> AllCategory { get; }

        public Category GetCategoryByID(int id);

        public IEnumerable<CategoryDetail> AllCategoryDetails { get; }
        public CategoryDetail GetCategoryDetailsForCategory(int categoryId);
        public CategoryDetail GetSubCategoryForCategoryByID(int CategoryId, int SubCategoryId);
    }
}
