using Microsoft.AspNetCore.Mvc;
using TefMVCApplication1.Models;

namespace TefMVCApplication1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Hoşgeldiniz";
            return View();
        }

        [HttpPost]
        public IActionResult Index( string UserName,string Password)
        {
            ViewBag.Title = "Hoşgeldiniz GAZİ TEF";
            Authentication cslAuth=new Authentication();

            if (cslAuth.UsernamePasswordControl(UserName, Password))
            {
                ViewBag.Mesaj = "giriş başarılı TEBRİKLER";
                HttpContext.Session.SetString("UserSession", "1");
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Mesaj = cslAuth.ErrorMessage;
            }
            return View();
        }

        public IActionResult deneme()
        {
            ViewBag.Title = "Hoşgeldiniz";
            return View();
        }
    }
}
