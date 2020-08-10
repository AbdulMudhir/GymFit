using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public interface IProductRepository
    {

        public IEnumerable<Product> AllProducts { get; }

        public Product GetProductByID(int id);

        public IEnumerable<Product> ProductsForHomePage { get; }

        public IEnumerable<ProductDetail> GetProductsByCategoryId(int id);

        public IEnumerable<ProductDetail> GetProductsByCategoryDetailId(int categoryDetailId);

        public void AddProduct(Product product);

        public void RemoveProduct(Product product);


        public void UpdateProduct(Product product);
    }
}
