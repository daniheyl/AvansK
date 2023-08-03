using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.DomainServices
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Task AddProduct(Product product);

        Task<Product> GetProductById(int id);

        Task EditProduct(Product product);

        Task DeleteProductById(int id);

    }

}



