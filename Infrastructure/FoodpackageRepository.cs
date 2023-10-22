using Core.Domain;
using Core.DomainServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class FoodpackageRepository : IFoodPackageRepository
    {
        private readonly FoodPackageDbContext _context;

        public FoodpackageRepository(FoodPackageDbContext context)
        {
            _context = context;
        }

        public async Task AddPackage(FoodPackage newPackage)
        {
            try
            {
                _context.Add(newPackage);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            //throw new NotImplementedException();
        }

        public Task EditProduct(FoodPackage newProduct)
        {
            throw new NotImplementedException();
        }

        public async Task<FoodPackage> Get(int id)
        {
            try
            {
                FoodPackage package = await _context.FoodPackages.Where(e => e.Id == id).FirstOrDefaultAsync();
                return package;
            }
            catch (Exception)
            {
                throw;
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<FoodPackage> GetAll()
        {
            return _context.FoodPackages.Include(package => package.PackageDetails).ToList();
        }

        public async Task RemoveProduct(int id)
        {
            var package = Get(id);
            _context.FoodPackages.Remove(package);
            await _context.SaveChangesAsync();
        }
    }
}
