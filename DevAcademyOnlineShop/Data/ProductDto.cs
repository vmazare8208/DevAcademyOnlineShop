using System.ComponentModel.DataAnnotations;

namespace DevAcademyOnlineShop.Data;

public record ProductDto(
    [Required][StringLength(maximumLength:200)] string ProductName,
    [Required][StringLength(maximumLength: 1000)] string productDescription,
    [Range(minimum:0, maximum: double.MaxValue)] decimal productPrice,
    [Range(minimum: 0, maximum: int.MaxValue)] int stockQuantity,
    [Required][StringLength(maximumLength: 200)] string productCategory
    );

