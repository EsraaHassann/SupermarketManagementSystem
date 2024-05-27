using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementSystem.Interfaces;

namespace SupermarketManagementSystem
{
   public class ProductB:Iproduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductB(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
