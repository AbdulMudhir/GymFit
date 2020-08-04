using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class MockProductRepository : IProductRepository
    {

        private readonly MockImageRepository _mockImageRepository = new MockImageRepository();
        private readonly MockCategoryRepository _mockCategoryRepository = new MockCategoryRepository();



        public IEnumerable<Product> AllProducts => new List<Product>() {
         new Product {
             ProductId= 1,
             Name="Dumb bells",
             ProductDetail = new List<ProductDetail>{
             new ProductDetail{
             StockAmount = 2000,
             Price = 120,
             PreviousPrice = 240,
             ProductId = 1,
             ProductDetailId = 1,
             CategoryDetail = _mockCategoryRepository.GetSubCategoryForCategoryByID(3, 3),
             Images =  _mockImageRepository.GetImagesByProductDetailId(1)

             }

             },

             Sale = false,
             IsFrontPageProduct = true,




         },

             new Product {
             ProductId= 3,
             Name="Whey Protien 100%",

             ProductDetail = new List<ProductDetail> {
                 new ProductDetail{
                     StockAmount = 2000,
                     Price = 40,
                     PreviousPrice = 84,
                     ProductId = 3,
                     ProductDetailId = 3,
                     CategoryDetail = _mockCategoryRepository.GetCategoryDetailsForCategory(4),
                     Images =  _mockImageRepository.GetImagesByProductDetailId(3)

                    }
             },

             Sale = false,
             IsFrontPageProduct = false,

        },
               new Product {
             ProductId= 2,
             Name="Decline BenchPress",

             ProductDetail = new List<ProductDetail> {
                 new ProductDetail{
                     StockAmount = 2000,
                     Price = 120,
                     PreviousPrice = 240,
                     ProductId = 2,
                     ProductDetailId = 2,
                     CategoryDetail = _mockCategoryRepository.GetSubCategoryForCategoryByID(3, 3),
                     Images =  _mockImageRepository.GetImagesByProductDetailId(2)

                    }
             },

             Sale = false,
             IsFrontPageProduct = true,

        }
        };

        public IEnumerable<Product> ProductsForHomePage => AllProducts.Where(p => p.IsFrontPageProduct);
      

        public Product GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int id)
        {
            return AllProducts.Where(p => p.ProductDetail.Where(d => d.CategoryDetail.CategoryId == id).Count() != 0);
        }

        public IEnumerable<Product> GetProductsBySubCategory(int categoryId, int subcategoryid)
        {
            return AllProducts.Where(p => p.ProductDetail.Where(d => d.CategoryDetail.CategoryId == categoryId &&  d.CategoryDetail.SubCategory.SubCategoryId == subcategoryid).Count() != 0);
        }
    }
}
