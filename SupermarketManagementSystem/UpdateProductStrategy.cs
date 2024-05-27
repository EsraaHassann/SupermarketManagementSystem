using SupermarketManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SupermarketManagementSystem
{
    public class UpdateProductStrategy : IProductStrategy
    {
        private DBConnect dBCon = new DBConnect();

        public void Execute(Product product)
        {
            string updateQuery = $"UPDATE Product SET ProdName='{product.Name}', ProdPrice={product.Price}, ProdQty={product.Quantity}, ProdCat='{product.Category}' WHERE ProdId = {product.Id}";
            SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            dBCon.CloseCon();
        }
    }
}
