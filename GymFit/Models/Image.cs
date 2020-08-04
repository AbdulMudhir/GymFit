using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        public int ProductDetailId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}
