using System;
using Refactoring.Enums;

namespace Refactoring.Models
{
    public class Product
    {
        public int EndHour { get; set; }
        public string ProductName { get; set; }
        public ProductTypes ProductType { get; set; }
        public int StartHour { get; set; }

        public bool IsAvailableAt(DateTime dateTime)
        {
            return this.IsAvailableAt(dateTime.Hour);
        }

        public bool IsAvailableAt(int hour)
        {
            return this.ProductType == ProductTypes.AllDay ||
                   (this.StartHour <= hour && this.EndHour >= hour);
        }
    }
}