using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Demo.Controllers
{
    public class EmployeesController : Controller
    {
        //create lsi obj class of employee
        //static

        // add static key ward to save data after add 
        static List<Employee> tblemployees = new List<Employee>
        {
            new Employee {
                EmployeeId = 1,
                EmployeeName = "sami",
                Salary=500,
                HDate= DateTime.Now,
                IsActive=false,
            },
            new Employee {
                EmployeeId = 2,
                EmployeeName = "Rola",
                Salary=120,
                HDate= DateTime.Now,
                IsActive=true,
            },
        };

        [HttpGet]
        public IActionResult AllEmployees()
        {
            return View(tblemployees);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var emp = (from x in tblemployees where x.EmployeeId == id select x).FirstOrDefault();

            return View(emp);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee objemp)
        {
            tblemployees.Add(objemp);
            return RedirectToAction("AllEmployees");

        }


        public IActionResult Delete(int id)
        {
            var delEmp = (from x in tblemployees where x.EmployeeId == id select x).FirstOrDefault();
            tblemployees.Remove(delEmp);
            return RedirectToAction("AllEmployees");
        }
    }
}
