using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UILayoutViewComponents
{
    public class _TopBarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
