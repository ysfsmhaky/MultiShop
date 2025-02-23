using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentPartial:ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
