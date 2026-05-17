using PI.BLL.DTOs.Orders;

namespace PI.BLL.Interfaces;

public interface IOrderService
{
    Task<Guid> CreateAsync(CreateOrderRequest request, Guid userId);
    Task UpdateStatusAsync(UpdateOrderStatusRequest request);
    Task DeleteAsync(Guid orderId);
    Task<OrderResponse?> GetByIdAsync(Guid orderId);
    Task<List<OrderResponse>> GetAllAsync();
    Task<List<OrderResponse>> GetUserOrdersAsync(Guid userId);
}