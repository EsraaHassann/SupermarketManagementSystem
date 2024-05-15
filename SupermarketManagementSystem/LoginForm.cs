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
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.CornflowerBlue;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.CornflowerBlue;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void Button_login_Click(object sender, EventArgs e)

        {
            if(TextBox_username.Text=="" ||TextBox_password.Text=="" )
            {
                MessageBox.Show("Please enter Username and Password","Missing infromation",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(comboBox_role.SelectedIndex>-1)
            { 
            if (comboBox_role.SelectedItem.ToString() == "ADMIN")
            {
                if(TextBox_username.Text=="Admin" && TextBox_password.Text=="Admin123")
                {
                    ProductForm product = new ProductForm();
                    product.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("If you are Admin , Please Enter the correct id and Password", "Miss id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string selectQuery = "SELECT FROM Seller WHERE SellerName='" + TextBox_username.Text + "' AND SellerPass='" + TextBox_password.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count>0)
                {
                        SellingForm selling = new SellingForm();
                        selling.Show();
                        this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
            else
            {
                MessageBox.Show("Please Select Role", "Wrong Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void label_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseLeave_1(object sender, EventArgs e)
        {
            label1.ForeColor = Color.CornflowerBlue;
        }
    }
}
