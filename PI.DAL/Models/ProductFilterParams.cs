namespace PI.DAL.Models;

public class ProductFilterParams
{
    public string? SearchTerm { get; set; }
    public Guid? CategoryId { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public string? SortBy { get; set; }

    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}