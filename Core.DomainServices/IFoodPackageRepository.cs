using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices
{
    public interface IFoodPackageRepository
    {
        IEnumerable<FoodPackage> GetAll();

        Task<FoodPackage> Get(int id);

        Task AddPackage(FoodPackage newPackage);

        Task EditProduct(FoodPackage newProduct);

        Task RemoveProduct(int id);
    }
}
