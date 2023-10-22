using Core.Domain;

namespace Portal.Models;

public class CreateFoodPackage
{
    public string Name { get; set; }

    public List<Product> Products { get; set; }
}
   


