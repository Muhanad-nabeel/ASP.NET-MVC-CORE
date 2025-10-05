using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Vision()
        {
            string Fname = "Mohanad";
            string Lname = "Nabil";
            string FullName = Fname + Lname;
            ViewBag.Name = FullName;

            string n1, n2;
            n1 = "5";
            n2 = "4";
            string total=(Convert.ToInt32(n1)+Convert.ToInt32(n2)).ToString();
            ViewBag.sum=total;


            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }


    }
}
