using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class ProductRepository:IProductRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }



        public IEnumerable<Product> AllProducts => _databaseContext.Products.Where(p => !p.IsFrontPageProduct).Include(p => p.ProductDetail).
            ThenInclude( p => p.CategoryDetail).ThenInclude(p=> p.Category)
            .Include(p => p.ProductDetail).ThenInclude(p => p.Images);

        public IEnumerable<Product> ProductsForHomePage => _databaseContext.Products.Where(p => p.IsFrontPageProduct).Include(p => p.ProductDetail).
            ThenInclude(p => p.CategoryDetail).ThenInclude(p => p.Category)
            .Include(p => p.ProductDetail).ThenInclude(p => p.Images);
        

        public Product GetProductByID(int id)
        {
            return _databaseContext.Products.Where(p => p.ProductId == id).Include(p => p.ProductDetail).
            ThenInclude(p => p.CategoryDetail).ThenInclude(p => p.Category)
            .Include(p => p.ProductDetail).ThenInclude(p => p.Images).First();
        }

        public IEnumerable<ProductDetail> GetProductsByCategoryId(int id)
        {
            return _databaseContext.ProductDetails.Where(p => p.CategoryDetail.CategoryId == id).Include(p => p.Product).Include(p => p.Images)
                .AsEnumerable().GroupBy(p => p.ProductId).Select(p => p.First());
        }

        public IEnumerable<ProductDetail> GetProductsByCategoryDetailId(int categoryDetailId)
        {


            return _databaseContext.ProductDetails.Where(p => p.CategoryDetailId == categoryDetailId).Include(p => p.Product).Include(p => p.Images);
            
           
        }



    }
}
