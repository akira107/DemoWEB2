using Microsoft.AspNetCore.Mvc;

namespace DemoWEB2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add()
        {
            try
            {
                int num1 = Convert.ToInt32(Request.Form["SoA"].ToString());
                int num2 = Convert.ToInt32(Request.Form["SoB"].ToString());
                ViewBag.Result = (num1 + num2).ToString();
            }
            catch (Exception)
            {

                ViewBag.Result="Du lieu nhap sai";
            }
            return View("CalPage");
        }

        [HttpPost]
        public IActionResult Minus()
        {
            try
            {
                int num1 = Convert.ToInt32(Request.Form["SoA"].ToString());
                int num2 = Convert.ToInt32(Request.Form["SoB"].ToString());
                ViewBag.Result = (num1 - num2).ToString();
            }
            catch (Exception)
            {

                ViewBag.Result = "Du lieu nhap sai";
            }
            return View("CalPage");
        }

        [HttpPost]
        public IActionResult Multiply()
        {
            try
            {
                int num1 = Convert.ToInt32(Request.Form["SoA"].ToString());
                int num2 = Convert.ToInt32(Request.Form["SoB"].ToString());
                ViewBag.Result = (num1 * num2).ToString();
            }
            catch (Exception)
            {

                ViewBag.Result = "Du lieu nhap sai";
            }
            return View("CalPage");
        }

        [HttpPost]
        public IActionResult Divide()
        {
            try
            {
                int num1 = Convert.ToInt32(Request.Form["SoA"].ToString());
                int num2 = Convert.ToInt32(Request.Form["SoB"].ToString());
                ViewBag.Result = (num1 / num2).ToString();
            }
            catch (Exception)
            {

                ViewBag.Result = "Du lieu nhap sai";
            }
            return View("CalPage");
        }
    }
}
