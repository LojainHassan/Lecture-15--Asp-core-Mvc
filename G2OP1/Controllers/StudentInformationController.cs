using Microsoft.AspNetCore.Mvc;
using G2OP1.Models.Student;

namespace G2OP1.Controllers
{
    public class StudentInformationController : Controller
    {
        List<Student> students = new List<Student>
        {
            new Student()
            {
                StudentId=1,
                StudentName="Evan Hassan",
                StudentAge=22,
                City="ALKarak",
                Email="Evan@gmail.com"
            }
            ,
            new Student()
            {
                StudentId=2,
                StudentName="Lojain Hassan",
                StudentAge=25,
                City="ALKarak",
                Email="lojain998@gmail.com"
            }
            ,
            new Student()
            {
                StudentId=3,
                StudentName="Anas Issam",
                StudentAge=42,
                City="Amman",
                Email="Anas@gmail.com"
            }

        };
        public IActionResult Index()
        {
            return View(students);
        }
    }
}
