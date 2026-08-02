using Microsoft.AspNetCore.Mvc;
using AutomobileManagementSystem.Models;

namespace AutomobileManagementSystem.Controllers
{
    public class ManufacturerController : Controller
    {
        public IActionResult Index()
        {
            Manufacturer manufacturer = new Manufacturer
            {
                ManufacturerName = "Tata Motors",
                Country = "India",
                ContactNumber = "9876543210",
                EmailAddress = "info@tatamotors.com"
            };

            return View(manufacturer);
        }
    }
}