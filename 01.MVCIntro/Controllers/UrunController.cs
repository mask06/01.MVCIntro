using Microsoft.AspNetCore.Mvc;

namespace _01.MVCIntro.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
