using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("vibin")]
    public class TestController : Controller
    {
        [Route("home")]
        public IActionResult index()
        {
            return View();
        }

        [Route("display")]
        public IActionResult Display()
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student("Vibin",1001,20,2017);
            Student student2 = new Student("Gowtham",1002,21,2018);
            Student student3 = new Student("Raj",1003,22,2022);
            Student student4 = new Student("Rahul",1004,23,2021);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            return View(students);
        }
    }
}
