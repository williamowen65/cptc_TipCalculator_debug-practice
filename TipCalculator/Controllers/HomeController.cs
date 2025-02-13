using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            // Initialize ViewBag properties to zero for displaying default tip amounts
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;

            Calculator calculator = new Calculator();

            return View(calculator); // Added return statement
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = calc.CalculateTip(0.15);
                ViewBag.Twenty = calc.CalculateTip(0.20);
                ViewBag.TwentyFive = calc.CalculateTip(0.25);
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(calc);
        }
    }
}