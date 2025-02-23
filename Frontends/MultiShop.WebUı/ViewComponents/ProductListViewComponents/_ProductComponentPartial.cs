using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ProductListViewComponents
{
    public class _ProductComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
