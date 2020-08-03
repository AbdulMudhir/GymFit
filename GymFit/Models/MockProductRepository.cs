﻿using Microsoft.AspNetCore.Authorization.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class MockProductRepository : IProductRepository
    {

        MockImageRepository _mockImageRepository = new MockImageRepository();



        public IEnumerable<Product> AllProducts => new List<Product>() {
         new Product {
             ProductId= 1,
             Name="Dumb bells",
             Price = 120,
             PreviousPrice = 240,
             Sale = false,
             IsFrontPageProduct = true,
             Images = _mockImageRepository.AllImages.Where(i => i.ProductId == 1)
                        },

             new Product {
             ProductId= 2,
             Name="Decline BenchPress",
             Price = 120,
             PreviousPrice = 240,
             Sale = false,
             IsFrontPageProduct = true,
             Images = _mockImageRepository.AllImages.Where(i => i.ProductId == 2)
                        }

        };

        public IEnumerable<Product> ProductsForHomePage => AllProducts.Where(p => p.IsFrontPageProduct);
      

        public Product GetProductByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
