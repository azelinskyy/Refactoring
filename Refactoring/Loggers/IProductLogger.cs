using System.Collections.Generic;
using Refactoring.Models;

namespace Refactoring.Loggers
{
    public interface IProductLogger
    {
        void LogMessage(string message);

        void LogProductsList(List<Product> products);

        void LogProduct(Product product);
    }
}