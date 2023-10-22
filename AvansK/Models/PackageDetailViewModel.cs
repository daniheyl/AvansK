
namespace Portal.Models;

public class PackageDetailViewModel
{
    public int Id { get; set; }

    public int FoodPackageId { get; set; }

    public int ProductId { get; set; }

    public ProductViewModel Product { get; set; } = null!;

    public FoodPackageViewModel FoodPackage { get; set; } = null!;
}
