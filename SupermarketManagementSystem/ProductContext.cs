using SupermarketManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    public class ProductContext
    {
        private IProductStrategy _strategy;

        public void SetStrategy(IProductStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(Product product)
        {
            _strategy.Execute(product);
        }
    }
}
