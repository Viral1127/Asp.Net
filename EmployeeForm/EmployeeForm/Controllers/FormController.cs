using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeForm.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
        public IActionResult Department()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult EmployeeProject()
        {
            return View();
        }
    }
}
