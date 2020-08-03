using GymFit.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Components
{
    public class Navigation:ViewComponent
    {

        ICategoryRepository _categoryRepository;

        public Navigation(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {

            return View(_categoryRepository.AllCategory);


        }
    }
}
