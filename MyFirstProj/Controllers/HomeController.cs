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
            Student std1 = new Student()
            {
                id = 1,
                name="Vibhuti",
                age = 21
            };
            Student std2 = new Student()
            {
                id = 2,
                name="Firoj",
                age = 20
            };
            Student std3 = new Student()
            {
                id = 3,
                name = "Viboz",
                age = 2
            };

            List<Student> std_list = new List<Student>();
            std_list.Add(std1);
            std_list.Add(std2);
            std_list.Add(std3);

            return View(std_list);
        }

        public IActionResult About() //action method with name Index
        {
            return View();
        }

        [Route("{id?}")]
        public IActionResult Details(int id)
        {
            Student std3 = new Student()
            {
                id = id,
                name = "Viboz",
                age = 2
            };
            return View(std3);
        }
    }
}
