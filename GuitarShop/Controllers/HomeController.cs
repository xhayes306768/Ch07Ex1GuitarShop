﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("ContactUs")]
        public IActionResult ContactUs()
        {

            var contact = new Dictionary<string, string>
            { { "Phone", "555-123-4567" },
              { "Email", "info@myguitarshop.com" },
              {"Social Media", "Facebook" }
                
                    };



            return View(contact);
        }




    }
}
