using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{

    public class MockSubCategoryRepository : ISubCategoryRepository
    {
        public IEnumerable<SubCategory> AllSubCategories => new List<SubCategory>
        {

            new SubCategory
            {
                SubCategoryId= 1,
                Name="Men"
            },
              new SubCategory
            {
                SubCategoryId= 2,
                Name="Women"
            },
                new SubCategory
            {
                SubCategoryId= 3,
                Name="Weights/Dumbbells"
            },
                     new SubCategory
            {
                SubCategoryId= 4,
                Name="Fitness Equipment"
            },
        };

        public SubCategory GetSubCategoryByID(int id)
        {
            return AllSubCategories.FirstOrDefault(s => s.SubCategoryId == id);
        }
    }
}
