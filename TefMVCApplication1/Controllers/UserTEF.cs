using Microsoft.AspNetCore.Mvc;
using TefMVCApplication1.Services;
using TefMVCApplication1.ViewModels;

namespace TefMVCApplication1.Controllers
{
    public class UserTEF : Controller
    {
        public IActionResult Index()
        {
            UserService userService = new UserService();
            var vm=userService.GetUserList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserVM vm)
        {
            if (ModelState.IsValid)
            {
                UserService userService = new UserService();
                userService.CreateUser(vm);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
