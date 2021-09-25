using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {

        [Route("[action]")]
        [Route("~/")]       //for default path to also point to Index()
        public IActionResult Index() //action method with name Index
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About() //action method with name Index
        {
            return View();
        }

        [Route("[action]/{id?}")]
        public int Details(int? id)
        {
            return id??1;   //null coalescing operator
        }
    }
}
