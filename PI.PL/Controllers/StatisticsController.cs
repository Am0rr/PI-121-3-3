using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PI.BLL.DTOs.Statistic;
using PI.BLL.Interfaces;

namespace PI.PL.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin")]
public class StatisticsController : ControllerBase
{
    private readonly IStatisticsService _statisticsService;

    public StatisticsController(IStatisticsService statisticsService)
    {
        _statisticsService = statisticsService;
    }

    [HttpGet("summary")]
    public async Task<ActionResult<SummaryResponse>> GetSummaryAsync([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, CancellationToken cancellationToken)
    {
        var result = await _statisticsService.GetSummaryAsync(startDate, endDate, cancellationToken);

        return Ok(result);
    }

    [HttpGet("top-products")]
    public async Task<ActionResult<IEnumerable<TopProductResponse>>> GetTopProductsAsync([FromQuery] int limit = 10, CancellationToken cancellationToken = default)
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
    public async Task<ActionResult<IEnumerable<LowStockResponse>>> GetLowStockAsync([FromQuery] int threshold = 10, CancellationToken cancellationToken = default)
    {
        var result = await _statisticsService.GetLowStockProductsAsync(threshold, cancellationToken);

        return Ok(result);
    }

    [HttpGet("top-users")]
    public async Task<ActionResult<IEnumerable<TopUserResponse>>> GetTopUsersAsync([FromQuery] int limit = 10, CancellationToken cancellationToken = default)
    {
        var result = await _statisticsService.GetTopUsersAsync(limit, cancellationToken);

        return Ok(result);
    }
}