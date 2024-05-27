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
using System.Web.UI.WebControls;

namespace SupermarketManagementSystem
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryForm()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
            getTable(); // Load data into the DataGridView when the form loads
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button8_logout_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                _categoryRepository.AddCategory(textBox1_id.Text, textBox_Name.Text, textBox_des.Text);
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1_id.Text) || string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_des.Text))
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _categoryRepository.UpdateCategory(textBox1_id.Text, textBox_Name.Text, textBox_des.Text);
                    MessageBox.Show("Category Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                _categoryRepository.DeleteCategory(textBox1_id.Text);
                MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_category_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1_category.SelectedCells.Count > 0) // Check if any cell is selected
            {
                int rowIndex = dataGridView1_category.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1_category.Rows[rowIndex];

                // Ensure the selected row is not a new row (if DataGridView allows adding new rows)
                if (!selectedRow.IsNewRow)
                {
                    textBox1_id.Text = Convert.ToString(selectedRow.Cells["CatId"].Value);
                    textBox_Name.Text = Convert.ToString(selectedRow.Cells["CatName"].Value);
                    textBox_des.Text = Convert.ToString(selectedRow.Cells["CatDes"].Value);
                }
            }
        }

        private void button8_logout_MouseEnter_1(object sender, EventArgs e)
        {
            button8_logout.ForeColor = Color.Red;
        }

        private void button8_logout_MouseLeave_1(object sender, EventArgs e)
        {
            button8_logout.ForeColor = Color.CornflowerBlue;
        }

        private void label1_MouseEnter_1(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.CornflowerBlue;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear()
        {
            textBox1_id.Clear();
            textBox_Name.Clear();
            textBox_des.Clear();
        }

        private void getTable()
        {
            dataGridView1_category.DataSource = _categoryRepository.GetCategories();
        }

        private void button7_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void button6_product_Click_1(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button5_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}