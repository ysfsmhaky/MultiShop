using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
