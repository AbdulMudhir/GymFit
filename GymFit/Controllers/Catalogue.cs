using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Controllers
{
    public class Catalogue:Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [ActionName("subcategory")]
        public IActionResult Index(int subcategoryId, int categoryId)
        {
            return View("Index");
        }

        [ActionName("category")]
        public IActionResult Index(int categoryId)
        {
            return View("Index");
        }
    }
}
