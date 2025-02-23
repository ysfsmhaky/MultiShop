using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
