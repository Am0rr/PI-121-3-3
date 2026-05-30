namespace PI.BLL.DTOs.Statistic;

public record CategoryRevenueResponse(
    string CategoryName,
    decimal TotalRevenue
);