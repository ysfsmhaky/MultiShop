using MediatR;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandler
{
    public class UpdateOrdeingCommand:IRequest
    {
        public int OrderingId { get; set; }
        public string UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class UpdateOrderinCommandHandler : IRequestHandler<UpdateOrdeingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public UpdateOrderinCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrdeingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.OrderingId);
            values.OrderDate = request.OrderDate;   
            values.TotalPrice = request.TotalPrice;
            values.OrderDate = request.OrderDate;
            values.UserId = request.UserId;
        }
    }
}
