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
using SupermarketManagementSystem.Interfaces;

namespace SupermarketManagementSystem
{
    public partial class ProductForm : Form
    {
        private ProductContext productContext = new ProductContext();
        private DBConnect dBCon = new DBConnect();

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

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
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

        private void LoadProducts()
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
                if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_price.Text) || string.IsNullOrEmpty(textBox_qty.Text) || string.IsNullOrEmpty(comboBox_category.Text))
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product product = new Product
                    {
                        Id = int.Parse(textBox_id.Text),
                        Name = textBox_name.Text,
                        Price = decimal.Parse(textBox_price.Text),
                        Quantity = int.Parse(textBox_qty.Text),
                        Category = comboBox_category.Text
                    };

                    productContext.SetStrategy(new AddProductStrategy());
                    productContext.ExecuteStrategy(product);

                    MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
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
                if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_price.Text) || string.IsNullOrEmpty(textBox_qty.Text) || string.IsNullOrEmpty(comboBox_category.Text))
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product product = new Product
                    {
                        Id = int.Parse(textBox_id.Text),
                        Name = textBox_name.Text,
                        Price = decimal.Parse(textBox_price.Text),
                        Quantity = int.Parse(textBox_qty.Text),
                        Category = comboBox_category.Text
                    };

                    productContext.SetStrategy(new UpdateProductStrategy());
                    productContext.ExecuteStrategy(product);

                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_id.Text))
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product product = new Product
                    {
                        Id = int.Parse(textBox_id.Text)
                    };

                    productContext.SetStrategy(new DeleteProductStrategy());
                    productContext.ExecuteStrategy(product);

                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
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
            LoadProducts();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = $"SELECT * FROM Product WHERE ProdCat = '{comboBox_search.SelectedValue}'";
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
    }
}
