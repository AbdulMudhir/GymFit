using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }

        public Product Product { get; set; }

        public int StockAmount { get; set; }

        public int ProductId { get; set; }

        public int SizeId { get; set; }

        public int FlavourId { get; set; }

        public int Weights { get; set; }

        public IEnumerable<Image> Images { get; set; }

        public int CategoryDetailId { get; set; }

        public CategoryDetail CategoryDetail { get; set; }

        public Decimal Price { get; set; }

        public Decimal PreviousPrice { get; set; }

    }
}
