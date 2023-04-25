using Microsoft.AspNetCore.Mvc;
using TefMVCApplication1.Models;

namespace TefMVCApplication1.Controllers
{
    public class TefController : Controller
    {
        public IActionResult Index()
        {
            Otomobil clsoto=new Otomobil();
            clsoto.Renk = "Beyaz";
            bool muayane=clsoto.MuayeneVarmı();


            arac clsarac = new arac();
            arac clsarac2 = new arac("beyaz", 1000, "Türkiye");

            return View();
        }
    }
}
