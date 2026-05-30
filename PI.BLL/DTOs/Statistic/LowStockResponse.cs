namespace PI.BLL.DTOs.Statistic;
public record LowStockResponse(
    Guid ProductId,
    string Name,
    int StockQuantity
);