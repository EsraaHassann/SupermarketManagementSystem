using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    partial class CategoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.dataGridView1_category = new System.Windows.Forms.DataGridView();
            this.label7_manageCat = new System.Windows.Forms.Label();
            this.button3_Delete = new System.Windows.Forms.Button();
            this.button2_Update = new System.Windows.Forms.Button();
            this.button1_Add = new System.Windows.Forms.Button();
            this.textBox_des = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5_seller = new System.Windows.Forms.Button();
            this.button6_product = new System.Windows.Forms.Button();
            this.button7_selling = new System.Windows.Forms.Button();
            this.button8_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_category)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.textBox1_id);
            this.panel1.Controls.Add(this.dataGridView1_category);
            this.panel1.Controls.Add(this.label7_manageCat);
            this.panel1.Controls.Add(this.button3_Delete);
            this.panel1.Controls.Add(this.button2_Update);
            this.panel1.Controls.Add(this.button1_Add);
            this.panel1.Controls.Add(this.textBox_des);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(159, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 611);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1_id
            // 
            this.textBox1_id.ForeColor = System.Drawing.Color.Black;
            this.textBox1_id.Location = new System.Drawing.Point(142, 108);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(200, 33);
            this.textBox1_id.TabIndex = 17;
            // 
            // dataGridView1_category
            // 
            this.dataGridView1_category.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_category.ColumnHeadersHeight = 24;
            this.dataGridView1_category.Location = new System.Drawing.Point(366, 108);
            this.dataGridView1_category.Name = "dataGridView1_category";
            this.dataGridView1_category.RowHeadersWidth = 51;
            this.dataGridView1_category.Size = new System.Drawing.Size(550, 490);
            this.dataGridView1_category.StandardTab = true;
            this.dataGridView1_category.TabIndex = 16;
            this.dataGridView1_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_category_CellContentClick_1);
            // 
            // label7_manageCat
            // 
            this.label7_manageCat.AutoSize = true;
            this.label7_manageCat.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_manageCat.ForeColor = System.Drawing.Color.White;
            this.label7_manageCat.Location = new System.Drawing.Point(338, 4);
            this.label7_manageCat.Name = "label7_manageCat";
            this.label7_manageCat.Size = new System.Drawing.Size(342, 48);
            this.label7_manageCat.TabIndex = 15;
            this.label7_manageCat.Text = "MANAGE CATEGORIES";
            // 
            // button3_Delete
            // 
            this.button3_Delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3_Delete.FlatAppearance.BorderSize = 0;
            this.button3_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_Delete.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Delete.ForeColor = System.Drawing.Color.White;
            this.button3_Delete.Location = new System.Drawing.Point(248, 275);
            this.button3_Delete.Name = "button3_Delete";
            this.button3_Delete.Size = new System.Drawing.Size(94, 43);
            this.button3_Delete.TabIndex = 12;
            this.button3_Delete.Text = "Delete";
            this.button3_Delete.UseVisualStyleBackColor = false;
            this.button3_Delete.Click += new System.EventHandler(this.button3_Delete_Click_1);
            // 
            // button2_Update
            // 
            this.button2_Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2_Update.FlatAppearance.BorderSize = 0;
            this.button2_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Update.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Update.ForeColor = System.Drawing.Color.White;
            this.button2_Update.Location = new System.Drawing.Point(146, 275);
            this.button2_Update.Name = "button2_Update";
            this.button2_Update.Size = new System.Drawing.Size(94, 43);
            this.button2_Update.TabIndex = 11;
            this.button2_Update.Text = "Update";
            this.button2_Update.UseVisualStyleBackColor = false;
            this.button2_Update.Click += new System.EventHandler(this.button2_Update_Click_1);
            // 
            // button1_Add
            // 
            this.button1_Add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1_Add.FlatAppearance.BorderSize = 0;
            this.button1_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Add.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Add.ForeColor = System.Drawing.Color.White;
            this.button1_Add.Location = new System.Drawing.Point(46, 275);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(94, 43);
            this.button1_Add.TabIndex = 10;
            this.button1_Add.Text = "Add";
            this.button1_Add.UseVisualStyleBackColor = false;
            this.button1_Add.Click += new System.EventHandler(this.button1_Add_Click_1);
            // 
            // textBox_des
            // 
            this.textBox_des.ForeColor = System.Drawing.Color.Black;
            this.textBox_des.Location = new System.Drawing.Point(142, 196);
            this.textBox_des.Name = "textBox_des";
            this.textBox_des.Size = new System.Drawing.Size(200, 33);
            this.textBox_des.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // textBox_Name
            // 
            this.textBox_Name.ForeColor = System.Drawing.Color.Black;
            this.textBox_Name.Location = new System.Drawing.Point(142, 150);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 33);
            this.textBox_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(1071, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter_1);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // button5_seller
            // 
            this.button5_seller.BackColor = System.Drawing.SystemColors.Control;
            this.button5_seller.FlatAppearance.BorderSize = 0;
            this.button5_seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5_seller.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_seller.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button5_seller.Location = new System.Drawing.Point(8, 34);
            this.button5_seller.Name = "button5_seller";
            this.button5_seller.Size = new System.Drawing.Size(140, 52);
            this.button5_seller.TabIndex = 16;
            this.button5_seller.Text = "Seller";
            this.button5_seller.UseVisualStyleBackColor = false;
            this.button5_seller.Click += new System.EventHandler(this.button5_seller_Click);
            // 
            // button6_product
            // 
            this.button6_product.BackColor = System.Drawing.SystemColors.Control;
            this.button6_product.FlatAppearance.BorderSize = 0;
            this.button6_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6_product.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6_product.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6_product.Location = new System.Drawing.Point(8, 115);
            this.button6_product.Name = "button6_product";
            this.button6_product.Size = new System.Drawing.Size(140, 52);
            this.button6_product.TabIndex = 17;
            this.button6_product.Text = "Product";
            this.button6_product.UseVisualStyleBackColor = false;
            this.button6_product.Click += new System.EventHandler(this.button6_product_Click_1);
            // 
            // button7_selling
            // 
            this.button7_selling.BackColor = System.Drawing.SystemColors.Control;
            this.button7_selling.FlatAppearance.BorderSize = 0;
            this.button7_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7_selling.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7_selling.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7_selling.Location = new System.Drawing.Point(8, 191);
            this.button7_selling.Name = "button7_selling";
            this.button7_selling.Size = new System.Drawing.Size(140, 52);
            this.button7_selling.TabIndex = 18;
            this.button7_selling.Text = "Selling";
            this.button7_selling.UseVisualStyleBackColor = false;
            this.button7_selling.Click += new System.EventHandler(this.button7_selling_Click);
            // 
            // button8_logout
            // 
            this.button8_logout.BackColor = System.Drawing.SystemColors.Control;
            this.button8_logout.FlatAppearance.BorderSize = 0;
            this.button8_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8_logout.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8_logout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8_logout.Location = new System.Drawing.Point(8, 586);
            this.button8_logout.Name = "button8_logout";
            this.button8_logout.Size = new System.Drawing.Size(140, 52);
            this.button8_logout.TabIndex = 19;
            this.button8_logout.Text = "Logout";
            this.button8_logout.UseVisualStyleBackColor = false;
            this.button8_logout.Click += new System.EventHandler(this.button8_logout_Click_1);
            this.button8_logout.MouseEnter += new System.EventHandler(this.button8_logout_MouseEnter_1);
            this.button8_logout.MouseLeave += new System.EventHandler(this.button8_logout_MouseLeave_1);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button8_logout);
            this.Controls.Add(this.button7_selling);
            this.Controls.Add(this.button6_product);
            this.Controls.Add(this.button5_seller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox_des;
        private Label label4;
        private TextBox textBox_Name;
        private Label label3;
        private Button button3_Delete;
        private Button button2_Update;
        private Button button1_Add;
        private Label label7_manageCat;
        private Button button5_seller;
        private Button button6_product;
        private Button button7_selling;
        private DataGridView dataGridView1_category;
        private TextBox textBox1_id;
        private Button button8_logout;
    }
}
