using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        [JsonIgnore]
        public IEnumerable<CategoryDetail> CategoryDetails { get; set; }

    }
}
