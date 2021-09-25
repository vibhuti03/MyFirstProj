using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index() //action method with name Index
        {
            return View();
        }

        [Route("Home/About")]
        public IActionResult About() //action method with name Index
        {
            return View();
        }

        [Route("Home/Details/{id?}")]
        public int Details(int? id)
        {
            return id??1;   //null coalescing operator
        }

        [Route("Home/My")]
        public IActionResult Data() //action method with name Index
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
