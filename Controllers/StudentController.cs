using AplikacioniPareTestCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplikacioniPareTestCore.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> s = new List<Student>
            {
                new Student{ Id=1,Emri="Jonida",Mosha=22},
                new Student{ Id=2,Emri="Sokol",Mosha=21},
                new Student{ Id=3,Emri="Testi",Mosha = 22}
            };
        public IActionResult Index()
        {
            var liste=s.ToList();  

            return View(liste);
        }

        public IActionResult Gjej(int id)
        {
        
            var student=s.Find(x => x.Id==id);

            return View(student);

        }
        public IActionResult Kontakt()
        {
            ViewData["Message"] = "Pershendetje, mireserdhet në .NET Core";
            return View();
        }
    }
}
