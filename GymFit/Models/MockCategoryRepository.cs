using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {

        private readonly MockSubCategoryRepository _mockSubCategoryRepository = new MockSubCategoryRepository();

        public IEnumerable<Category> AllCategory =>
            new List<Category>
            {
              new Category
              {
                  CategoryId = 1,
                  Name = "Clothings",
                  Image = "/Images/Clothing.jpg",
                  CategoryDetails = new List<CategoryDetail>{ 
                  
                      new CategoryDetail{ 
                      CategoryDetailId = 1,
                      CategoryId = 1,
                      SubCategory = _mockSubCategoryRepository.GetSubCategoryByID(1)
                      },
                        new CategoryDetail{
                      CategoryDetailId = 2,
                      CategoryId = 1,
                      SubCategory = _mockSubCategoryRepository.GetSubCategoryByID(2)
                      }

                  }

              },
                new Category
              {
                  CategoryId = 2,
                  Name = "FootWears",
                  Image = "/Images/Footwear.jpg",
                  CategoryDetails = new List<CategoryDetail>{

                      new CategoryDetail{
                      CategoryDetailId = 3,
                      CategoryId = 2,
                      SubCategory = _mockSubCategoryRepository.GetSubCategoryByID(1)
                      },
                        new CategoryDetail{
                      CategoryDetailId = 4,
                      CategoryId = 2,
                      SubCategory = _mockSubCategoryRepository.GetSubCategoryByID(2)
                      }

                  }

              },new Category
              {
                  CategoryId = 3,
                  Name = "Equipments",
                  Image = "/Images/equipments.jpg",
                  CategoryDetails = new List<CategoryDetail>{

                      new CategoryDetail{
                      CategoryDetailId = 3,
                      CategoryId = 3,
                      SubCategory = _mockSubCategoryRepository.GetSubCategoryByID(3)
                      },
                        new CategoryDetail{
                      CategoryDetailId = 4,
                      CategoryId = 3,
                      SubCategory = _mockSubCategoryRepository.GetSubCategoryByID(4)
                      }

                  }




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

        public CategoryDetail GetSubCategoryForCategoryByID(int CategoryId, int SubCategoryId)
        {
            return AllCategory.FirstOrDefault(c => c.CategoryId == CategoryId)
                .CategoryDetails.FirstOrDefault(s => s.SubCategory.SubCategoryId == SubCategoryId);
        }
    }
}
