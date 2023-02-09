using Microsoft.AspNetCore.Mvc;
using Home.Models;
namespace Home.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            ViewBag.Id = emp.Id;
            ViewBag.Name = emp.Name;
            ViewBag.Mobile = emp.Mobile;
            ViewBag.Salary = emp.Salary;
          
            return View("Show");
        }

    }
}
