using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //action method with name Index
        {
            return View();
        }

        public IActionResult About() //action method with name Index
        {
            return View();
        }

        public int Details(int id)
        {
            return id;
        }
    }
}
