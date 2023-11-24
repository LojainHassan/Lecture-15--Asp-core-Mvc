using Microsoft.AspNetCore.Mvc;
using G2OP1.Models;
namespace G2OP1.Controllers
{
    public class HomeController : Controller
    {
        IList<Employee> emp= new List<Employee>
        {
            new Employee {Id=1,
                FirstName="Lojain",
                LatName="Hassan",
                Age=20,
                City="Amman",
                RegisterDate=DateTime.Now
            },
             new Employee {Id=2,
                FirstName="Anas",
                LatName="Hassan",
                Age=40,
                City="AL-Karak",
                RegisterDate=DateTime.Now
            },
              new Employee {Id=3,
                FirstName="Evan",
                LatName="Hassan",
                Age=21,
                City="Ajloun",
                RegisterDate=DateTime.Now
            }


        };
        public IActionResult Index()
        {


            return View();
        }
       

        public IActionResult AboutUs() {
            ViewBag.MyName = "Lojain";
            ViewBag.TrainingName = "AspCore";
            ViewData["DateToday"]=DateTime.Now;
            return View();
        }

        public IActionResult Vision()
        {
            return View();
        }

        public IActionResult AllEmployee()
        {

            return View(emp);
        }


    }
}
