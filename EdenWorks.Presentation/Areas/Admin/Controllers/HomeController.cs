using EdenWorks.Application.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Areas.Admin
{
    [Area("Admin")]
    [NeedAuthentication]
    public class HomeController : Controller
    {
        public IActionResult AdminMain()
        {
            return View();
        }
    }
}
