using MediatR;
using Core.Interfaces;
using Core.Entities;

namespace Application.Queries.Handlers;

public class GetSummaryQueryHandler : IRequestHandler<GetSummaryQuery, List<Order>>
{
    private readonly IOrderRepository _orderRepository;

    public GetSummaryQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<List<Order>> Handle(GetSummaryQuery request, CancellationToken cancellationToken)
    {
        return await _orderRepository.GetSummaryAsync();
    }
}
