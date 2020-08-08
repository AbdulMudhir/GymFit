using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class CategoryRepository:ICategoryRepository
    {

        private readonly DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Category> AllCategory => _databaseContext.Categories.Include(c => c.CategoryDetails).ThenInclude(cd => cd.SubCategory);

        public Category GetCategoryByID(int id)
        {
            return AllCategory.FirstOrDefault(c => c.CategoryId == id);
        }

        public CategoryDetail GetSubCategoryForCategoryByID(int CategoryId, int SubCategoryId)
        {
            return AllCategory.FirstOrDefault(c => c.CategoryId == CategoryId)
                .CategoryDetails.FirstOrDefault(s => s.SubCategory.SubCategoryId == SubCategoryId);
        }

        public CategoryDetail GetCategoryDetailsForCategory(int categoryId)
        {
            var category = AllCategory.FirstOrDefault(c => c.CategoryId == categoryId);

            return new CategoryDetail { CategoryId = category.CategoryId };
        }
    }
}
