using Core.Domain;
using Core.DomainServices;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers
{
    public class FoodPackageController : Controller
    {
        private readonly IFoodPackageRepository _foodPackageRepository;
        private readonly IProductRepository _productRepository;

        public FoodPackageController(IFoodPackageRepository foodPackageRepository, IProductRepository productRepository)
        {
            _foodPackageRepository = foodPackageRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            PreFillFoodPackage();
            var listOfWeetIkVeel = _foodPackageRepository.GetAll();
            return View(listOfWeetIkVeel);
        }

        public IActionResult Add()
        {
            ViewBag.Products= _productRepository.GetAll();

            var products = _productRepository.GetAll();
            var viewModel = new CreateFoodPackage { Products = (List<Product>)products };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _foodPackageRepository.RemoveProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> NewPackage(CreateFoodPackage package)
        {
            //var newFoodPackage = new FoodPackage(package.);

            //await _foodPackageRepository.AddPackage();
            return RedirectToAction("Index");
        }

        private void PreFillFoodPackage()
        {
            var products = _productRepository.GetAll();
            ViewBag.Products = products;

        }
    }
}
