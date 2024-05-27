using SupermarketManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SupermarketManagementSystem
{
    public class AddProductStrategy : IProductStrategy
    {
        private DBConnect dBCon = new DBConnect();

        public void Execute(Product product)
        {
            string insertQuery = $"INSERT INTO Product VALUES({product.Id}, '{product.Name}', {product.Price}, {product.Quantity}, '{product.Category}')";
            SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            dBCon.CloseCon();
        }
    }
}
