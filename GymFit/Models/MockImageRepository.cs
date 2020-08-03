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
            ProductId = 1,
            Url = "/productimages/dumbbell1.png"
            },

            new Image
            {
            ImageId = 2,
            ProductId = 2,
            Url = "/productimages/decline-benchpress.png"
            },

        };
    }
}
