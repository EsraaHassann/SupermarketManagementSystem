using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    public interface ICategoryRepository
    {
        void AddCategory(string id, string name, string description);
        void UpdateCategory(string id, string name, string description);
        void DeleteCategory(string id);
        DataTable GetCategories();
    }

}
