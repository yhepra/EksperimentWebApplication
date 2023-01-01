using EksperimentWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksperimentWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();
            student.Add(new Student
            {
                Id = 1,
                Name = "Romi Kusuma Bakti",
                Address = "Boyolali",
                PhoneNumber = "08001"
            });

            student.Add(new Student
            {
                Id = 2,
                Name = "Agus Rahman Hidayat",
                Address = "Ciamis",
                PhoneNumber = "08002"
            });

            return View(student);
        }
    }
}
