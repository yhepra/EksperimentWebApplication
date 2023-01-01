using EksperimentWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksperimentWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student()
            {
                Id = 1,
                Name = "Romi Kusuma Bakti",
                Address = "Boyolali",
                PhoneNumber = "08001"
            };

            return View(student);
        }
    }
}
