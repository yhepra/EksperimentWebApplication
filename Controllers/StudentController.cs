using EksperimentWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksperimentWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student[]
            {
                new Student{ Id = 1, Name = "Romi Kusuma Bakti", Address = "Boyolali", PhoneNumber = "08001"},
                new Student{ Id = 2, Name = "Agus Rahman Hidayat", Address = "Ciamis", PhoneNumber = "08002"},
                new Student{ Id = 3, Name = "Dimas Firmansyah", Address = "Banjar", PhoneNumber = "08003"},
                new Student{ Id = 4, Name = "Dede Adam Alamsyah", Address = "Banjarsari", PhoneNumber = "08004"},
                new Student{ Id = 5, Name = "Sawaludin", Address = "Padangsidimpuan", PhoneNumber = "08005"}
            };
            

            return View(student);
        }
    }
}
