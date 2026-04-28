using Microsoft.EntityFrameworkCore;
using PI.DAL.Entities.Orders;
using PI.DAL.Interfaces;

namespace PI.DAL.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{

    public OrderRepository(AppDbContext context) : base(context) { }
    public async Task<IEnumerable<Order>> GetByUserIdAsync(Guid userId, CancellationToken ct = default)
    {
        return await _context.Set<Order>()
            .Where(o => o.UserId == userId)
            .ToListAsync(ct);
    }
    public async Task<Order?> GetWithDetailsAsync(Guid id, CancellationToken ct = default)
    {
        return await _context.Set<Order>()
            .Include(o => o.OrderItems)
                .ThenInclude(i => i.Product)
            .FirstOrDefaultAsync(o => o.Id == id, ct);
    }
}