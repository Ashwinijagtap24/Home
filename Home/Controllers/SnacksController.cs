using Microsoft.AspNetCore.Mvc;

namespace Home.Controllers
{
    public class SnacksController : Controller
    {
        [HttpGet]
        public IActionResult CustomerDetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerDetails(IFormCollection form ,ICollection<string> Snacks)
        {
            ViewBag.Name = form["Cname"];
            ViewBag.Mobile = form["Mobile"];
            ViewBag.Snack = Snacks;
            return View("ShowSnack");
        }
    }
}
