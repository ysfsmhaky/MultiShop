using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
