using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUı.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
