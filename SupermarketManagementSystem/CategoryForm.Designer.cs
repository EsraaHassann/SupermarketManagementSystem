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
            panel1 = new Panel();
            textBox1_id = new TextBox();
            dataGridView1_category = new DataGridView();
            label7_manageCat = new Label();
            button3_Delete = new Button();
            button2_Update = new Button();
            button1_Add = new Button();
            textBox_des = new TextBox();
            label4 = new Label();
            textBox_Name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5_seller = new Button();
            button6_product = new Button();
            button7_selling = new Button();
            button8_logout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_category).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(textBox1_id);
            panel1.Controls.Add(dataGridView1_category);
            panel1.Controls.Add(label7_manageCat);
            panel1.Controls.Add(button3_Delete);
            panel1.Controls.Add(button2_Update);
            panel1.Controls.Add(button1_Add);
            panel1.Controls.Add(textBox_des);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(159, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 611);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1_id
            // 
            textBox1_id.ForeColor = Color.Black;
            textBox1_id.Location = new Point(142, 108);
            textBox1_id.Name = "textBox1_id";
            textBox1_id.Size = new Size(200, 33);
            textBox1_id.TabIndex = 17;
            textBox1_id.TextChanged += textBox1_id_TextChanged;
            // 
            // dataGridView1_category
            // 
            dataGridView1_category.BackgroundColor = Color.White;
            dataGridView1_category.ColumnHeadersHeight = 24;
            dataGridView1_category.Location = new Point(366, 108);
            dataGridView1_category.Name = "dataGridView1_category";
            dataGridView1_category.RowHeadersWidth = 51;
            dataGridView1_category.Size = new Size(550, 490);
            dataGridView1_category.StandardTab = true;
            dataGridView1_category.TabIndex = 16;
            dataGridView1_category.CellContentClick += dataGridView1_category_CellContentClick;
            // 
            // label7_manageCat
            // 
            label7_manageCat.AutoSize = true;
            label7_manageCat.Font = new Font("Sitka Display", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7_manageCat.ForeColor = Color.White;
            label7_manageCat.Location = new Point(338, 4);
            label7_manageCat.Name = "label7_manageCat";
            label7_manageCat.Size = new Size(354, 49);
            label7_manageCat.TabIndex = 15;
            label7_manageCat.Text = "MANAGE CATEGORIES";
            // 
            // button3_Delete
            // 
            button3_Delete.BackColor = Color.CornflowerBlue;
            button3_Delete.FlatAppearance.BorderSize = 0;
            button3_Delete.FlatStyle = FlatStyle.Flat;
            button3_Delete.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3_Delete.ForeColor = Color.White;
            button3_Delete.Location = new Point(248, 275);
            button3_Delete.Name = "button3_Delete";
            button3_Delete.Size = new Size(94, 43);
            button3_Delete.TabIndex = 12;
            button3_Delete.Text = "Delete";
            button3_Delete.UseVisualStyleBackColor = false;
            button3_Delete.Click += button3_Delete_Click;
            // 
            // button2_Update
            // 
            button2_Update.BackColor = Color.CornflowerBlue;
            button2_Update.FlatAppearance.BorderSize = 0;
            button2_Update.FlatStyle = FlatStyle.Flat;
            button2_Update.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2_Update.ForeColor = Color.White;
            button2_Update.Location = new Point(146, 275);
            button2_Update.Name = "button2_Update";
            button2_Update.Size = new Size(94, 43);
            button2_Update.TabIndex = 11;
            button2_Update.Text = "Update";
            button2_Update.UseVisualStyleBackColor = false;
            button2_Update.Click += button2_Update_Click;
            // 
            // button1_Add
            // 
            button1_Add.BackColor = Color.CornflowerBlue;
            button1_Add.FlatAppearance.BorderSize = 0;
            button1_Add.FlatStyle = FlatStyle.Flat;
            button1_Add.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1_Add.ForeColor = Color.White;
            button1_Add.Location = new Point(46, 275);
            button1_Add.Name = "button1_Add";
            button1_Add.Size = new Size(94, 43);
            button1_Add.TabIndex = 10;
            button1_Add.Text = "Add";
            button1_Add.UseVisualStyleBackColor = false;
            button1_Add.Click += button1_Add_Click;
            // 
            // textBox_des
            // 
            textBox_des.ForeColor = Color.Black;
            textBox_des.Location = new Point(142, 196);
            textBox_des.Name = "textBox_des";
            textBox_des.Size = new Size(200, 33);
            textBox_des.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 196);
            label4.Name = "label4";
            label4.Size = new Size(129, 33);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // textBox_Name
            // 
            textBox_Name.ForeColor = Color.Black;
            textBox_Name.Location = new Point(142, 150);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(200, 33);
            textBox_Name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 152);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 108);
            label2.Name = "label2";
            label2.Size = new Size(38, 33);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(1071, -12);
            label1.Name = "label1";
            label1.Size = new Size(33, 39);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // button5_seller
            // 
            button5_seller.BackColor = SystemColors.Control;
            button5_seller.FlatAppearance.BorderSize = 0;
            button5_seller.FlatStyle = FlatStyle.Flat;
            button5_seller.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5_seller.ForeColor = Color.CornflowerBlue;
            button5_seller.Location = new Point(18, 82);
            button5_seller.Name = "button5_seller";
            button5_seller.Size = new Size(135, 52);
            button5_seller.TabIndex = 16;
            button5_seller.Text = "Seller";
            button5_seller.UseVisualStyleBackColor = false;
            // 
            // button6_product
            // 
            button6_product.BackColor = SystemColors.Control;
            button6_product.FlatAppearance.BorderSize = 0;
            button6_product.FlatStyle = FlatStyle.Flat;
            button6_product.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6_product.ForeColor = Color.CornflowerBlue;
            button6_product.Location = new Point(18, 173);
            button6_product.Name = "button6_product";
            button6_product.Size = new Size(140, 52);
            button6_product.TabIndex = 17;
            button6_product.Text = "Product";
            button6_product.UseVisualStyleBackColor = false;
            button6_product.Click += button6_product_Click;
            // 
            // button7_selling
            // 
            button7_selling.BackColor = SystemColors.Control;
            button7_selling.FlatAppearance.BorderSize = 0;
            button7_selling.FlatStyle = FlatStyle.Flat;
            button7_selling.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7_selling.ForeColor = Color.CornflowerBlue;
            button7_selling.Location = new Point(18, 267);
            button7_selling.Name = "button7_selling";
            button7_selling.Size = new Size(140, 52);
            button7_selling.TabIndex = 18;
            button7_selling.Text = "Selling";
            button7_selling.UseVisualStyleBackColor = false;
            // 
            // button8_logout
            // 
            button8_logout.BackColor = SystemColors.Control;
            button8_logout.FlatAppearance.BorderSize = 0;
            button8_logout.FlatStyle = FlatStyle.Flat;
            button8_logout.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8_logout.ForeColor = Color.CornflowerBlue;
            button8_logout.Location = new Point(18, 585);
            button8_logout.Name = "button8_logout";
            button8_logout.Size = new Size(140, 52);
            button8_logout.TabIndex = 19;
            button8_logout.Text = "Logout";
            button8_logout.UseVisualStyleBackColor = false;
            button8_logout.Click += button8_logout_Click;
            button8_logout.MouseEnter += button8_logout_MouseEnter;
            button8_logout.MouseLeave += button8_logout_MouseLeave;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 650);
            Controls.Add(button8_logout);
            Controls.Add(button7_selling);
            Controls.Add(button6_product);
            Controls.Add(button5_seller);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_category).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
