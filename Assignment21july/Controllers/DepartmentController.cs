using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Details()
        {
            if (TempData["Department"] == null)
            {
                return RedirectToAction("Register", "Employee");
            }

            Department dept = new Department()
            {
                DepartmentName = TempData["Department"].ToString(),
                DepartmentHead = "Rahul Sharma",
                HeadContactNumber = "9876543210",
                HeadEmail = "rahul@gmail.com"
            };

            return View(dept);
        }
    }
}