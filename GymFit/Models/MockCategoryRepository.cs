using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {

        MockSubCategoryRepository _mockSubCategoryRepository = new MockSubCategoryRepository();

        public IEnumerable<Category> AllCategory =>
            new List<Category>
            {
              new Category
              {
                  CategoryId = 1,
                  Name = "Clothings",
                  Image = "/Images/Clothing.jpg",
                  SubCategories = _mockSubCategoryRepository.AllSubCategories.Where(s => new List<int>(){ 1,2 }.Contains(s.SubCategoryId) )

              },
                new Category
              {
                  CategoryId = 2,
                  Name = "FootWears",
                  Image = "/Images/Footwear.jpg",
                  SubCategories = _mockSubCategoryRepository.AllSubCategories.Where(s => new List<int>(){ 1,2 }.Contains(s.SubCategoryId) )

              },new Category
              {
                  CategoryId = 3,
                  Name = "Equipments",
                  Image = "/Images/equipments.jpg",
                   SubCategories = _mockSubCategoryRepository.AllSubCategories.Where(s => new List<int>(){3,4 }.Contains(s.SubCategoryId) )

              },
                new Category
              {
                  CategoryId = 4,
                  Name = "Suppliments",
                  Image = "/Images/Suppliment.jpg"

              },

            };

        public Category GetCategoryByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
