using System.Collections.Generic;
using Refactoring.Enums;
using Refactoring.Models;

namespace Refactoring.Loggers
{
    internal abstract class LoggerBase : IProductLogger
    {
        public abstract void LogMessage(string message);

        public virtual void LogProductsList(List<Product> products)
        {
                products.ForEach(LogProduct);
        }

        public virtual void LogProduct(Product product)
        {
            this.LogMessage(product.ProductType == ProductTypes.AllDay
                ? product.ProductName
                : string.Format("{0} ({1}:00-{2}:00)", product.ProductName, product.StartHour, product.EndHour));
        }
    }
}