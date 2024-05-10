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
    public partial class ProductForm : Form
    {
        DBConnect dBConnect = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(Object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "CatName";
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_products.DataSource = table;
        }

        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_qty.Clear();
            comboBox_category.SelectedIndex = 0;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES(" + textBox_id.Text + ",'" + textBox_name.Text + "'," + textBox_price.Text + "," + textBox_qty.Text + ",'" + comboBox_category.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBConnect.GetCon());
                dBConnect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
