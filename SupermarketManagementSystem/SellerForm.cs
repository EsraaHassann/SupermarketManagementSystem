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
            string selectQuery = "SELECT * FROM Seller";
            using (SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_seller.DataSource = table;
                }
            }
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

        {/*
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" ||  TextBox_age.Text == "" || TextBox_phone.Text == "" || TextBox_pass.Text == "")
                {
                    MessageBox.Show("Missing information", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string updateQuery = "Update Seller SET sellerName = '" + TextBox_name.Text + "',SellerAge=" + TextBox_age.Text + ",SellerPhone=" + TextBox_phone.Text + ",Sellerpass=" + TextBox_pass.Text + "'WHERE SellerId= " + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller updated succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
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

        { /*
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing information", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "deleted from seller where SellerId =" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted succesfully", "delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            
        }

        private void button6_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button7_selling_Click(object sender, EventArgs e)
        {
            //SellingForm selling = new SellingForm();
            //selling.Show();
            //this.Hide();
        }
    }
}
