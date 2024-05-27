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

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_seller.DataSource = table;
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
                string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_age.Text + "','" + TextBox_phone.Text + "','" + TextBox_pass.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller added succesfullyy", "Add information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_age.Clear();
            TextBox_phone.Clear();
            TextBox_pass.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.CornflowerBlue;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void Update_Click(object sender, EventArgs e)

        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_phone.Text == "" || TextBox_pass.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Seller SET SellerName='" + TextBox_name.Text + "',SellerAge='" + TextBox_age.Text + "',SellerPhone='" + TextBox_phone.Text + "',SellerPass='" + TextBox_pass.Text + "'WHERE SellerId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_seller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
           TextBox_id.Text = dataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_age.Text= dataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_phone.Text= dataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_pass.Text = dataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();*/
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void Delete_Click(object sender, EventArgs e)

        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button7_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void button8_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_seller_Click(object sender, EventArgs e)
        {


            if (dataGridView_seller.SelectedCells.Count > 0) // Check if any cell is selected
            {
                int rowIndex = dataGridView_seller.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_seller.Rows[rowIndex];

                // Ensure the selected row is not a new row (if DataGridView allows adding new rows)
                if (!selectedRow.IsNewRow)
                {
                    TextBox_id.Text = Convert.ToString(selectedRow.Cells["SellerId"].Value);
                    TextBox_name.Text = Convert.ToString(selectedRow.Cells["SellerName"].Value);
                    TextBox_age.Text = Convert.ToString(selectedRow.Cells["SellerAge"].Value);
                    TextBox_phone.Text = Convert.ToString(selectedRow.Cells["SellerPhone"].Value);
                    TextBox_pass.Text = Convert.ToString(selectedRow.Cells["SellerPass"].Value);
                    
                }
            }

            /*if (dataGridView_seller.SelectedCells.Count > 0) // Check if any cell is selected
            {
                int rowIndex = dataGridView_seller.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_seller.Rows[rowIndex];

                // Ensure the selected row is not a new row (if DataGridView allows adding new rows)
                if (!selectedRow.IsNewRow)
                {
                    TextBox_id.Text = Convert.ToString(selectedRow.Cells["SellerId"].Value);
                    TextBox_name.Text = Convert.ToString(selectedRow.Cells["SellerName"].Value);
                    TextBox_age.Text = Convert.ToString(selectedRow.Cells["SellerAge"].Value);
                    TextBox_phone.Text = Convert.ToString(selectedRow.Cells["SellerPhone"].Value);
                    TextBox_pass.Text = Convert.ToString(selectedRow.Cells["SellerPass"].Value);
                }
            }*/
        }

        private void button5_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
    }
}
