using SupermarketManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SupermarketManagementSystem
{
    public interface IProductStrategy
    {
        void Execute(Product product);
    }
}
