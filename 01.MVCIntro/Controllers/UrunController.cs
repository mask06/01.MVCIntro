using _01.MVCIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01.MVCIntro.Controllers
{
    public class UrunController : Controller
    {
        private static List<Urun> urunler = new List<Urun>
        {
            new Urun{Id=1,Ad="urun1",Fiyat = 100},
            new Urun{Id=2,Ad="urun2",Fiyat = 200},
            new Urun{Id=3,Ad="urun3",Fiyat = 300}
        };


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Liste()
        {
            return View(urunler);
        }
    }
}
