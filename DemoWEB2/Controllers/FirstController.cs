using DemoWEB2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWEB2.Controllers
{
    public class FirstController : Controller
    {

        //List<Person> people = new List<Person>
        //{
        //    new Person {Name="ABC", Age=19, Location="Ho Chi Minh"},
        //    new Person {Name="DEF", Age=20, Location="Ha Noi"},
        //    new Person {Name="GHK", Age=21, Location="Da Nang"},

        //};

        public string Index()
        {
            return "Hello , day la ung dung MVC";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "ViewBag Message";
            return View();
        }

        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Ho va Ten";
            person.Age = 18;
            person.Location = "Ho Chi Minh";

            return View(person);
        }

        public IActionResult List()
        {
            //List<Person> pers = new List<Person>()
            //Person[] pers = new Person[]
            var pers = new List<Person>()
            {
                new Person {Name="ABC", Age=19, Location="Ho Chi Minh"},
                new Person {Name="DEF", Age=20, Location="Ha Noi"},
                new Person {Name="GHK", Age=21, Location="Da Nang"}
            };
            return View(pers);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
