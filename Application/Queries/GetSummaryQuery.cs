using MediatR;
using Core.Entities;

namespace Application.Queries;

public class GetSummaryQuery : IRequest<List<Order>>
{
}
