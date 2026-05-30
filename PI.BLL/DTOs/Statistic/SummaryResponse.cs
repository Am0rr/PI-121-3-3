namespace PI.BLL.DTOs.Statistic;

public record SummaryResponse(
    decimal TotalRevenue,
    int TotalOrders
);