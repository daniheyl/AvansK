namespace Portal.Models;


public class FoodPackageViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ProductId { get; set; }

    public ICollection<PackageDetailViewModel>? PackageDetails { get; set; }
}
