namespace PI.BLL.DTOs.Catalog;

public record CreateCategoryRequest(
    string Name,
    string Description
);