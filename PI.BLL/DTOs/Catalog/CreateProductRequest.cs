namespace PI.BLL.DTOs.Catalog;

public record CreateProductRequest
{
    public Guid CategoryId { get; init; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public decimal Price { get; init; }
    public int StockQuantity { get; init; }
    public string? ImageUrl { get; init; }
}