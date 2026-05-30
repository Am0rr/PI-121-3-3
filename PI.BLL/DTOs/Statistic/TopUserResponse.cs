namespace PI.BLL.DTOs.Statistic;

public record TopUserResponse(
    Guid UserId,
    string Email,
    decimal TotalSpent,
    int TotalOrders
);