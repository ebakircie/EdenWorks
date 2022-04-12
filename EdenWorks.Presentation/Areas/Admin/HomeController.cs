using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Areas.Admin
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
