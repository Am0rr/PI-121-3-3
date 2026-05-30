using PI.BLL.DTOs.Statistic;

namespace PI.BLL.Interfaces;

public interface IStatisticsService
{
    Task<SummaryResponse> GetSummaryAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default);

    Task<IEnumerable<TopProductResponse>> GetTopSellingProductsAsync(int limit, CancellationToken cancellationToken = default);

    Task<IEnumerable<CategoryRevenueResponse>> GetRevenueByCategoryAsync(CancellationToken cancellationToken = default);

    Task<IEnumerable<LowStockResponse>> GetLowStockProductsAsync(int threshold, CancellationToken cancellationToken = default);

    Task<IEnumerable<TopUserResponse>> GetTopUsersAsync(int limit, CancellationToken cancellationToken = default);
}