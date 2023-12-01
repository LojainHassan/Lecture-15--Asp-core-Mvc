using G2OP1.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace G2OP1.Controllers
{
    public class AccountController : Controller
    {
        static List<User> UserList = new List<User>
        {
            new User{Id=1 , UserName="admin" , PassWord="admin",Email="admin@io" ,IsActive=true},
            new User{Id=2 , UserName="lojain" , PassWord="123",Email="lojain@io" ,IsActive=true},
            new User{Id=3 , UserName="anas" , PassWord="123",Email="anas@io" ,IsActive=false}
        };

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            
            if(UserList.Any(u=>u.UserName == user.UserName))
            {
                if(UserList.Any(u => u.PassWord == user.PassWord))
                {
                    ViewBag.LoginStatus = "Successfully Login";
                    if(UserList.Where(u=>u.UserName == user.UserName).SingleOrDefault().IsActive == false)
                    {
                        ViewBag.LoginStatus = "Your Account is Locked";
                        return View();
                    }

                    return RedirectToAction("Index", "StudentInformation");

                    

                }
                else
                {
                    ViewBag.LoginStatus = "Invalid Password";
                    return View();

                }
            }
            else
            {
                ViewBag.LoginStatus = "Invalid Username";
                return View();
            }


        }


        [HttpGet]
        public IActionResult MyProfile()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Id=UserList.Count()+1;
            user.IsActive = true;
            UserList.Add(user);
            
            return RedirectToAction("Login");
        }
    }
}
