using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class PackageDetail
    {
        public int Id { get; set; }

        public int FoodPackageId { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public FoodPackage FoodPackage { get; set; } = null!;
    }
}
