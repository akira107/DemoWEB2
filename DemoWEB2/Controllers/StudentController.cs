using DemoWEB2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWEB2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<StudentInfo>()
            {
                new StudentInfo {Id = "CT01", Name = "Thanh Nam", Marks = 7.5},
                new StudentInfo {Id = "CT02", Name = "Thanh Hai", Marks = 6.5},
                new StudentInfo {Id = "CT03", Name = "Thanh Huong", Marks = 8.5},
                new StudentInfo {Id = "CT04", Name = "Ngoc Thach", Marks = 7.5},
                new StudentInfo {Id = "CT05", Name = "Thai Binh", Marks = 8.5}
            };
            //OR
            /*
             List<StudentInfo> students = new List<StudentInfo>()
             {
                new StudentInfo {Id = "CT01", Name = "Thanh Nam", Marks = 7.5},
                new StudentInfo {Id = "CT02", Name = "Thanh Hai", Marks = 6.5},
                new StudentInfo {Id = "CT03", Name = "Thanh Huong", Marks = 8.5},
                new StudentInfo {Id = "CT04", Name = "Ngoc Thach", Marks = 7.5},
                new StudentInfo {Id = "CT05", Name = "Thai Binh", Marks = 8.5}
            };
             */
            ViewBag.TotalStudents = students.Count();
            return View(students);
        }

        public IActionResult ViewModelView()
        {
            ViewBag.StudentInfo = new StudentInfo();
            return View();
        }

       

    }
}
