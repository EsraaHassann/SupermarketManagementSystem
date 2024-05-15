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
    public partial class CategoryForm : Form
    {
        private readonly DBConnect dBCon = new DBConnect();

        public CategoryForm()
        {
            InitializeComponent();
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
                string insertQuery = "INSERT INTO Category VALUES(" + textBox1_id.Text + ", '" + textBox_Name.Text + "', '" + textBox_des.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
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
                if (textBox1_id.Text == "" || textBox_Name.Text == "" || textBox_des.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPADTE Category SET CatName = '" + textBox_Name.Text + "', CatDes = '" + textBox_des.Text + "' WHERE CatId = '" + textBox1_id.Text + "'";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE CatId = " + textBox1_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
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
            textBox1_id.Text = dataGridView1_category.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Name.Text = dataGridView1_category.SelectedRows[0].Cells[1].Value.ToString();
            textBox_des.Text = dataGridView1_category.SelectedRows[0].Cells[2].Value.ToString();
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
            string selectQuery = "SELECT * FROM Category";
            using (SqlCommand command = new SqlCommand (selectQuery, dBCon.GetCon()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1_category.DataSource = table;
                }
            }
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