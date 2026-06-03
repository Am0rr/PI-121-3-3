using PI.BLL.DTOs.Orders;

namespace PI.BLL.Interfaces;

public interface IOrderService
{
    Task<OrderResponse> CreateAsync(CreateOrderRequest request, Guid userId, CancellationToken cancellationToken);

    Task UpdateStatusAsync(Guid id, UpdateOrderStatusRequest request, CancellationToken cancellationToken);

    Task DeleteAsync(Guid orderId, CancellationToken cancellationToken);

    Task<OrderResponse> GetByIdAsync(Guid orderId, CancellationToken cancellationToken);

    Task<IEnumerable<OrderResponse>> GetAllAsync(CancellationToken cancellationToken);

    Task<IEnumerable<OrderResponse>> GetUserOrdersAsync(Guid userId, CancellationToken cancellationToken);
}