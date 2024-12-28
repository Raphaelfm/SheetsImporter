using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _context;

    public OrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddRangeAsync(IEnumerable<Order> orders)
    {
        await _context.Orders.AddRangeAsync(orders);
    }

    public async Task<List<Order>> GetAllAsync()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<List<Order>> GetSummaryAsync()
    {
        return await _context.Orders
            .GroupBy(o => o.Cliente)
            .Select(g => new Order
            {
                Cliente = g.Key,
                Valor = g.Sum(o => o.Valor),
                NF = g.Count().ToString(),
                ComissaoValor = g.Sum(o => o.ComissaoValor)
            }).ToListAsync();
    }
}
