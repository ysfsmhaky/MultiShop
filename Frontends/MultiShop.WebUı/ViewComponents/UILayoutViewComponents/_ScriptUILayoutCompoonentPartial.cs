using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutCompoonentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
