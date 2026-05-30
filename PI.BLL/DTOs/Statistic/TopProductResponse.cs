namespace PI.BLL.DTOs.Statistic;

public record TopProductResponse(
    Guid ProductId,
    string Name,
    int TotalItemsSold,
    decimal TotalRevenue
);