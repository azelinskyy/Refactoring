using System;
using System.Collections.Generic;
using System.Linq;
using Refactoring.Enums;
using Refactoring.Loggers;
using Refactoring.Models;

namespace Refactoring.Utils
{
    public static class ProductUtils
    {
        private static List<Product> _testData;

        public static List<Product> GetTestData()
        {
            return _testData ?? (_testData = new List<Product>
            {
                new Product {ProductName = "Orange Juice", ProductType = ProductTypes.AllDay},
                new Product
                {
                    ProductName = "Breakfast Burrito",
                    ProductType = ProductTypes.Limited,
                    StartHour = 8,
                    EndHour = 12
                },
                new Product
                {
                    ProductName = "Steak & Chips",
                    ProductType = ProductTypes.Limited,
                    StartHour = 12,
                    EndHour = 21
                },
                new Product
                {
                    ProductName = "Chicken Sandwich",
                    ProductType = ProductTypes.Limited,
                    StartHour = 11,
                    EndHour = 19
                },
                new Product
                {
                    ProductName = "Sam Adams Seasonal",
                    ProductType = ProductTypes.Limited,
                    StartHour = 17,
                    EndHour = 23
                }
            });
        }

        public static IEnumerable<Product> GetProductsAwailableAt(this IEnumerable<Product> pruducts, DateTime dateTime)
        {
            return pruducts.GetProductsAwailableAtHour(dateTime.Hour);
        }

        public static IEnumerable<Product> GetProductsAwailableAtHour(this IEnumerable<Product> pruducts, int hour)
        {
            return pruducts.Where(p => p.IsAvailableAt(hour));
        }

        public static void DisplayAvailableProducts(this List<Product> products, IProductLogger productLogger)
        {
            if (!products.Any())
                productLogger.LogMessage("There are no products available at this time of day");
            else
            {
                productLogger.LogMessage("Products available current time of day:");
                productLogger.LogProductsList(products);
            }
        }
    }
}