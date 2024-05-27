using SupermarketManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SupermarketManagementSystem
{
    public class DeleteProductStrategy : IProductStrategy
    {
        private DBConnect dBCon = new DBConnect();

        public void Execute(Product product)
        {
            string deleteQuery = $"DELETE FROM Product WHERE ProdId = {product.Id}";
            SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            dBCon.CloseCon();
        }
    }
}
