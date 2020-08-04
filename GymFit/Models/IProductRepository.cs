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

        public IEnumerable<Product> GetProductsByCategoryId(int id);

        public IEnumerable<Product> GetProductsBySubCategory(int categoryId, int subcategoryid);

    }
}
