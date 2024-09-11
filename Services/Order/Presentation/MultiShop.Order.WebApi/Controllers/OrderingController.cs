using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandler;
using MultiShop.Order.Application.Features.Mediator.Query.OrderingQueries;

namespace MultiShop.Order.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> OrderingList()
        {
            var values = await _mediator.Send(new GetOrderingQuery());
            return Ok(values);  
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderingById(int id)
        {
            var values = await _mediator.Send(new GetOrderingByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> OrderingCreate(CreateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sipariş başarı ile eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> OrderingDelete(int id)
        {
            await _mediator.Send(new RemoveOrderingCommand(id));
            return Ok("Sipariş başarı ile silindi");
        }
        [HttpPut]
        public async Task<IActionResult> OrderinUpdate(UpdateOrdeingCommand command)
        {
            await _mediator.Send(command);  
            return Ok("Sipariş başarı ile güncellendi");
        }

    }
}
