using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementSystem.Interfaces;

namespace SupermarketManagementSystem
{
    public class ProductA:Iproduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductA(string Name, decimal price)
        {
            Name = Name;
            price = price;
        }
    }
}
