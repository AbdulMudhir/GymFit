using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Components
{
    public class Navigation:ViewComponent
    {


        public IViewComponentResult Invoke()
        {

            return View();


        }
    }
}
