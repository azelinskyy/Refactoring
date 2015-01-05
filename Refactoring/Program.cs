using System;
using System.Linq;
using Refactoring.Loggers;
using Refactoring.Utils;

namespace Refactoring
{
    internal class Program
    {
        private static void Main()
        {
            var awailableProducts = ProductUtils.GetTestData().GetProductsAwailableAt(DateTime.Now).ToList();
            awailableProducts.DisplayAvailableProducts(new ConsoleLogger());

            Console.ReadKey();
        }
    }
}