using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PI.BLL.DTOs.Statistic;
using PI.BLL.Interfaces;
using PI.DAL.Enums;

namespace PI.PL.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = nameof(UserRole.Admin))]
public class StatisticsController : ControllerBase
{
    private readonly IStatisticsService _statisticsService;

    public StatisticsController(IStatisticsService statisticsService)
    {
        _statisticsService = statisticsService;
    }

    [HttpGet("summary")]
    public async Task<ActionResult<SummaryResponse>> GetSummaryAsync(CancellationToken cancellationToken, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
    {
        var result = await _statisticsService.GetSummaryAsync(startDate, endDate, cancellationToken);

        return Ok(result);
    }

    [HttpGet("top-products")]
    public async Task<ActionResult<IEnumerable<TopProductResponse>>> GetTopProductsAsync(CancellationToken cancellationToken, [FromQuery] int limit = 10)
    {
        var result = await _statisticsService.GetTopSellingProductsAsync(limit, cancellationToken);

        return Ok(result);
    }

    [HttpGet("revenue-by-category")]
    public async Task<ActionResult<IEnumerable<CategoryRevenueResponse>>> GetRevenueByCategoryAsync(CancellationToken cancellationToken)
    {
        var result = await _statisticsService.GetRevenueByCategoryAsync(cancellationToken);

        return Ok(result);
    }

    [HttpGet("low-stock")]
    public async Task<ActionResult<IEnumerable<LowStockResponse>>> GetLowStockAsync(CancellationToken cancellationToken, [FromQuery] int threshold = 10)
    {
        var result = await _statisticsService.GetLowStockProductsAsync(threshold, cancellationToken);

        return Ok(result);
    }

    [HttpGet("top-users")]
    public async Task<ActionResult<IEnumerable<TopUserResponse>>> GetTopUsersAsync(CancellationToken cancellationToken, [FromQuery] int limit = 10)
    {
        var result = await _statisticsService.GetTopUsersAsync(limit, cancellationToken);

        return Ok(result);
    }
}