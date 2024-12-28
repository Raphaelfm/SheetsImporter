using Core.Entities;

namespace Core.Interfaces;

public interface IOrderRepository
{
    Task AddRangeAsync(IEnumerable<Order> orders);
    Task<List<Order>> GetAllAsync();
    Task<List<Order>> GetSummaryAsync();
}
