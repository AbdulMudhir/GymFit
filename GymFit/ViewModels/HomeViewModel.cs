using GymFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.ViewModels
{
    public class HomeViewModel
    {
       public IEnumerable<Product> Products { get; set; }
    }
}
