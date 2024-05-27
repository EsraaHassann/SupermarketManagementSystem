using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SupermarketManagementSystem
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBConnect dBCon = new DBConnect();

        public void AddCategory(string id, string name, string description)
        {
            string insertQuery = "INSERT INTO Category (CatId, CatName, CatDes) VALUES (@Id, @Name, @Description)";
            using (SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon()))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                dBCon.CloseCon();
            }
        }

        public void UpdateCategory(string id, string name, string description)
        {
            string updateQuery = "UPDATE Category SET CatName = @Name, CatDes = @Description WHERE CatId = @Id";
            using (SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon()))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                dBCon.CloseCon();
            }
        }

        public void DeleteCategory(string id)
        {
            string deleteQuery = "DELETE FROM Category WHERE CatId = @Id";
            using (SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon()))
            {
                command.Parameters.AddWithValue("@Id", id);
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                dBCon.CloseCon();
            }
        }

        public DataTable GetCategories()
        {
            string selectQuery = "SELECT * FROM Category";
            using (SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
