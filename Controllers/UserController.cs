using Microsoft.AspNetCore.Mvc;
using PerformanceEvaluation.Models;

namespace PerformanceEvaluation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(user);
        }

        public IActionResult Success()
        {
            return View();
        }
    }

}
