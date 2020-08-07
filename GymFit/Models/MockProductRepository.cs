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

                    },
                  new ProductDetail{
                     StockAmount = 2000,
                     Price = 20,
                     PreviousPrice = 324,
                     ProductId = 3,
                     ProductDetailId = 4,
                     CategoryDetail = _mockCategoryRepository.GetCategoryDetailsForCategory(4),
                     Images =  _mockImageRepository.GetImagesByProductDetailId(4)

                    }
             },
            
             Safety = "May contain- Gluten, Egg, Nuts and Peanuts.",
             Ingredient = "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase," +
                 " Beta-D-Galactosidase, Lipase)",
             Description = " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to your"+
            "favourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .",


             Brand = "WHEY",
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
            return AllProducts.FirstOrDefault(p => p.ProductId == id);
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
