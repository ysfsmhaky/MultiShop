using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Basket.Dtos;
using MultiShop.Basket.Services;

namespace MultiShop.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginServices _loginServices;

        public BasketsController(IBasketService basketService, ILoginServices loginServices)
        {
            _basketService = basketService;
            _loginServices = loginServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetMyBasketDetail()
        {
           var user = User.Claims;
           return Ok(await _basketService.GetBasket(_loginServices.GetUserId));
        }
        [HttpPost]
        public async Task<IActionResult> SaveMyBasket(BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _loginServices.GetUserId;
            await _basketService.SaveBasket(basketTotalDto);
            return Ok("Sepetteki değişiklikler kayıt edildi");

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasket(_loginServices.GetUserId);
            return Ok("Sepet başarı ile silindi");
        }
    }
}
