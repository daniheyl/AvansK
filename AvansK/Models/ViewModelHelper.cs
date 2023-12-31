﻿using Core.Domain;

namespace Portal.Models
{
    public static class ViewModelHelper
    {
        public static List<ProductViewModel> ToViewModel(this IEnumerable<Product> products)
        {
            var result = new List<ProductViewModel>();

            foreach (var product in products)
            {
                result.Add(product.ToViewModel());
            }

            return result;
        }

        public static List<FoodPackageViewModel> ToViewModel(this IEnumerable<FoodPackage> foodPackages)
        {
            var result = new List<FoodPackageViewModel>();

            foreach (var foodPackage in foodPackages)
            {
                result.Add(foodPackage.ToViewModel());
            }

            return result;
        }

        public static ProductViewModel ToViewModel(this Product product)
        {
            var result = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                ContainsAlcohol = product.ContainsAlcohol,
                Picture = product.Picture,
            };

            return result;

        }

        public static FoodPackageViewModel ToViewModel(this FoodPackage foodPackage)
        {
            var result = new FoodPackageViewModel
            {
                Id = foodPackage.Id,
                Name = foodPackage.Name,
            };

            return result;

        }


    }
}
