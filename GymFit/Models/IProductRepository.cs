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


    }
}
