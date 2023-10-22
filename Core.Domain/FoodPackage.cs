using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class FoodPackage
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<PackageDetail> PackageDetails { get; set; } = new List<PackageDetail>();

        public FoodPackage() { }

        public FoodPackage ( int id, string name, List<Product> products, ICollection<PackageDetail> packageDetails)
        {
            Id = id;
            Name = name;
            PackageDetails = packageDetails;
        }

        public static implicit operator FoodPackage(Task<FoodPackage> v)
        {
            throw new NotImplementedException();
        }
    }
}
