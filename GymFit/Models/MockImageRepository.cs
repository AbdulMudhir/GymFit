using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class MockImageRepository : IImageRepository
    {
        public IEnumerable<Image> AllImages => new List<Image>()
        { new Image 
            { 
            ImageId = 1,
            ProductDetailId = 1,
            Url = "/productimages/dumbbell1.png"
            },

            new Image
            {
            ImageId = 2,
            ProductDetailId = 2,
            Url = "/productimages/decline-benchpress.png"
            },
              new Image
            {
            ImageId = 3,
            ProductDetailId = 3,
            Url = "/productimages/whey.jpg"
            },
        };

        public IEnumerable<Image> GetImagesByProductDetailId (int productDetailId)
        {
            return AllImages.Where(i => i.ProductDetailId == productDetailId);
        }
    }
}
