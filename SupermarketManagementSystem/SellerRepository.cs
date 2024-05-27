using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    public class SellerRepository : ISellerRepository
    {
        private readonly IDatabaseConnection _dbCon;

        public SellerRepository(IDatabaseConnection dbCon)
        {
            _dbCon = dbCon;
        }

        public DataTable GetAllSellers()
        {
            string selectQuery = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuery, _dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void AddSeller(string id, string name, string age, string phone, string pass)
        {
            string insertQuery = $"INSERT INTO Seller VALUES({id}, '{name}', '{age}', '{phone}', '{pass}')";
            SqlCommand command = new SqlCommand(insertQuery, _dbCon.GetCon());
            _dbCon.OpenCon();
            command.ExecuteNonQuery();
            _dbCon.CloseCon();
        }

        public void UpdateSeller(string id, string name, string age, string phone, string pass)
        {
            string updateQuery = $"UPDATE Seller SET SellerName='{name}', SellerAge='{age}', SellerPhone='{phone}', SellerPass='{pass}' WHERE SellerId={id}";
            SqlCommand command = new SqlCommand(updateQuery, _dbCon.GetCon());
            _dbCon.OpenCon();
            command.ExecuteNonQuery();
            _dbCon.CloseCon();
        }

        public void DeleteSeller(string id)
        {
            string deleteQuery = $"DELETE FROM Seller WHERE SellerId={id}";
            SqlCommand command = new SqlCommand(deleteQuery, _dbCon.GetCon());
            _dbCon.OpenCon();
            command.ExecuteNonQuery();
            _dbCon.CloseCon();
        }
    }

}
