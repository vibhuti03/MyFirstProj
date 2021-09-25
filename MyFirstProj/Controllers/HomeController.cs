using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {

        [Route("Index")]
        [Route("~/")]       //for default path to also point to Index()
        public IActionResult Index() //action method with name Index
        {
            return View();
        }

        [Route("About")]
        public IActionResult About() //action method with name Index
        {
            return View();
        }

        [Route("Details/{id?}")]
        public int Details(int? id)
        {
            return id??1;   //null coalescing operator
        }
    }
}
