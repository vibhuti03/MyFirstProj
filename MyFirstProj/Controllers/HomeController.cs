using Microsoft.AspNetCore.Mvc;
using MyFirstProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        [Route("~/")]       //for default path to also point to Index()
        [Route("~/[controller]")]
        public IActionResult Index() //action method with name Index
        {
            return View();
        }

        public IActionResult About() //action method with name About
        {
            return View();
        }

        [Route("{id?}")]
        public int Details(int id)  //action method with name Details
        {
            return id;
        }
    }
}
