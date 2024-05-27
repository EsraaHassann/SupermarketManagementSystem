using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementSystem.Interfaces;

namespace SupermarketManagementSystem.Factories
{
  public  class FactoryProduct
    {
        public static Iproduct CreateProduct(string productType)
        {
            switch (productType)
            {
                case "ProductA":
                    return new ProductA("Product A", 10.0m);
                case "ProductB":
                    return new ProductB("Product B", 20.0m);
                default:
                    throw new ArgumentException("Invalid Product Type");
            }
        }
    }
}
