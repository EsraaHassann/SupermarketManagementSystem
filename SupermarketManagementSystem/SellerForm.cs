using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketManagementSystem
{
    public partial class SellerForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_manageCat_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES (" + TextBox_id.Text + ",'" + TextBox_name.Text + "'," + TextBox_age.Text + "," + TextBox_phone.Text + ",'" + TextBox_pass.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller added succesfully", "Add information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                //getTable();
                //clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
