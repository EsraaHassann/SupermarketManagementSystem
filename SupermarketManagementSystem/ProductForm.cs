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
        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
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
            SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
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
            SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
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
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_price.Text == "" || textBox_qty.Text == "" || comboBox_category.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO Product VALUES(" + textBox_id.Text + ",'" + textBox_name.Text + "'," + textBox_price.Text + "," + textBox_qty.Text + ",'" + comboBox_category.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_price.Text == "" || textBox_qty.Text == "" || comboBox_category.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Product SET ProdName='" + textBox_name.Text + "',ProdPrice=" + textBox_price.Text + ",ProdQty=" + textBox_qty.Text + ",ProdCat='" + comboBox_category.Text + "' WHERE ProdId = " + textBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void dataGridView_products_Click(object sender, EventArgs e)
        {
            if (dataGridView_products.SelectedCells.Count > 0) // Check if any cell is selected
            {
                int rowIndex = dataGridView_products.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_products.Rows[rowIndex];

                // Ensure the selected row is not a new row (if DataGridView allows adding new rows)
                if (!selectedRow.IsNewRow)
                {
                    textBox_id.Text = Convert.ToString(selectedRow.Cells["ProdId"].Value);
                    textBox_name.Text = Convert.ToString(selectedRow.Cells["ProdName"].Value);
                    textBox_price.Text = Convert.ToString(selectedRow.Cells["ProdPrice"].Value);
                    textBox_qty.Text = Convert.ToString(selectedRow.Cells["ProdQty"].Value);
                    comboBox_category.Text = Convert.ToString(selectedRow.Cells["ProdCat"].Value);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId = " + textBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM Product WHERE ProdCat = '" + comboBox_search.SelectedValue.ToString() + "'";
                SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_products.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red; 
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Goldenrod;
        }

        private void button8_logout_MouseEnter(object sender, EventArgs e)
        {
            button8_logout.ForeColor = Color.Red;
        }

        private void button8_logout_MouseLeave(object sender, EventArgs e)
        {
            button8_logout.ForeColor = Color.Goldenrod;
        }

        private void button8_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void dataGridView_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            sellingForm.Show();
            this.Hide();
          }
    }
}
