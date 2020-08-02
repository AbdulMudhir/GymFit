using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategory =>
            new List<Category>
            {
              new Category
              {
                  CategoryId = 1,
                  Name = "Equipments",
                  Image = "~/wwwroot/Images/"
                 
              }

            };

        public Category GetCategoryByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
