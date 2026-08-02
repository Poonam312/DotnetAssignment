using Microsoft.AspNetCore.Mvc;
using AutomobileManagementSystem.Models;

namespace AutomobileManagementSystem.Controllers
{
    public class AutomobileController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                TempData["VehicleName"] = automobile.VehicleName;
                TempData["Brand"] = automobile.Brand;

                return RedirectToAction("Success");
            }

            return View(automobile);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}