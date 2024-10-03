    using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeForm.Controllers
{
    public class DepartmentController : Controller
    {

       
        public static int nextDepartmentID = 1;

        public IActionResult Index()
        {
            ViewBag.Departments = Database.departments;
            return View();
            
        }

        public IActionResult DepartmentForm() { 
            ViewBag.Departments = Database.departments;
            return View();
        }

        [HttpPost]
        public ActionResult DepartmentForm(Department department)
        {

            ViewBag.Departments = Database.departments;
            if (ModelState.IsValid)

            {
                department.DepartmentId = nextDepartmentID++;
                Database.departments.Add(department);
                return RedirectToAction("Index");
            }
            return View(Database.departments);
        }
    }
}
