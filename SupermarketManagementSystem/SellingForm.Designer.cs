
namespace SupermarketManagementSystem
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_id = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_sellsList = new System.Windows.Forms.DataGridView();
            this.button1_Add = new System.Windows.Forms.Button();
            this.button1_refresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.seller_name = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.TextBox_price = new System.Windows.Forms.TextBox();
            this.TextBox_qty = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7_manageCat = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.label_seller = new System.Windows.Forms.Label();
            this.button8_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label_amount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView_sellsList);
            this.panel1.Controls.Add(this.button1_Add);
            this.panel1.Controls.Add(this.button1_refresh);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.seller_name);
            this.panel1.Controls.Add(this.button_print);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Controls.Add(this.TextBox_qty);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.label7_manageCat);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Location = new System.Drawing.Point(110, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 604);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(663, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "BillId";
            // 
            // TextBox_id
            // 
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.Location = new System.Drawing.Point(716, 301);
            this.TextBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.Size = new System.Drawing.Size(84, 20);
            this.TextBox_id.TabIndex = 35;
            this.TextBox_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.Location = new System.Drawing.Point(685, 254);
            this.label_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(32, 28);
            this.label_amount.TabIndex = 34;
            this.label_amount.Text = "Ks";
            this.label_amount.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(450, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Amount";
            // 
            // dataGridView_sellsList
            // 
            this.dataGridView_sellsList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_sellsList.ColumnHeadersHeight = 24;
            this.dataGridView_sellsList.Location = new System.Drawing.Point(378, 335);
            this.dataGridView_sellsList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_sellsList.Name = "dataGridView_sellsList";
            this.dataGridView_sellsList.RowHeadersWidth = 51;
            this.dataGridView_sellsList.Size = new System.Drawing.Size(521, 186);
            this.dataGridView_sellsList.StandardTab = true;
            this.dataGridView_sellsList.TabIndex = 32;
            // 
            // button1_Add
            // 
            this.button1_Add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1_Add.FlatAppearance.BorderSize = 0;
            this.button1_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Add.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Add.ForeColor = System.Drawing.Color.White;
            this.button1_Add.Location = new System.Drawing.Point(132, 206);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(94, 33);
            this.button1_Add.TabIndex = 31;
            this.button1_Add.Text = "Add Order\r\n";
            this.button1_Add.UseVisualStyleBackColor = false;
            this.button1_Add.Click += new System.EventHandler(this.button1_Add_Click);
            // 
            // button1_refresh
            // 
            this.button1_refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1_refresh.FlatAppearance.BorderSize = 0;
            this.button1_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_refresh.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_refresh.ForeColor = System.Drawing.Color.White;
            this.button1_refresh.Location = new System.Drawing.Point(219, 254);
            this.button1_refresh.Name = "button1_refresh";
            this.button1_refresh.Size = new System.Drawing.Size(94, 43);
            this.button1_refresh.TabIndex = 30;
            this.button1_refresh.Text = "Refresh";
            this.button1_refresh.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 36);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Select Category";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(725, 25);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(55, 28);
            this.label_date.TabIndex = 27;
            this.label_date.Text = "Date:";
            // 
            // seller_name
            // 
            this.seller_name.AutoSize = true;
            this.seller_name.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_name.ForeColor = System.Drawing.Color.White;
            this.seller_name.Location = new System.Drawing.Point(32, 26);
            this.seller_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(105, 28);
            this.seller_name.TabIndex = 26;
            this.seller_name.Text = "SellerName";
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(805, 555);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(94, 43);
            this.button_print.TabIndex = 25;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(805, 287);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 43);
            this.button_add.TabIndex = 24;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button2_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sells List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_product.ColumnHeadersHeight = 24;
            this.dataGridView_product.Location = new System.Drawing.Point(37, 304);
            this.dataGridView_product.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersWidth = 51;
            this.dataGridView_product.Size = new System.Drawing.Size(285, 283);
            this.dataGridView_product.StandardTab = true;
            this.dataGridView_product.TabIndex = 22;
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // TextBox_price
            // 
            this.TextBox_price.ForeColor = System.Drawing.Color.Black;
            this.TextBox_price.Location = new System.Drawing.Point(106, 134);
            this.TextBox_price.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.ReadOnly = true;
            this.TextBox_price.Size = new System.Drawing.Size(151, 20);
            this.TextBox_price.TabIndex = 21;
            // 
            // TextBox_qty
            // 
            this.TextBox_qty.ForeColor = System.Drawing.Color.Black;
            this.TextBox_qty.Location = new System.Drawing.Point(106, 181);
            this.TextBox_qty.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_qty.Name = "TextBox_qty";
            this.TextBox_qty.Size = new System.Drawing.Size(151, 20);
            this.TextBox_qty.TabIndex = 20;
            this.TextBox_qty.UseSystemPasswordChar = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.White;
            this.Quantity.Location = new System.Drawing.Point(10, 173);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(82, 28);
            this.Quantity.TabIndex = 19;
            this.Quantity.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_order.ColumnHeadersHeight = 24;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.ProdTotal});
            this.dataGridView_order.Location = new System.Drawing.Point(378, 55);
            this.dataGridView_order.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.Size = new System.Drawing.Size(521, 186);
            this.dataGridView_order.StandardTab = true;
            this.dataGridView_order.TabIndex = 16;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.Name = "ProdQty";
            // 
            // ProdTotal
            // 
            this.ProdTotal.HeaderText = "ProdTotal";
            this.ProdTotal.Name = "ProdTotal";
            // 
            // label7_manageCat
            // 
            this.label7_manageCat.AutoSize = true;
            this.label7_manageCat.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_manageCat.ForeColor = System.Drawing.Color.White;
            this.label7_manageCat.Location = new System.Drawing.Point(254, 3);
            this.label7_manageCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7_manageCat.Name = "label7_manageCat";
            this.label7_manageCat.Size = new System.Drawing.Size(120, 39);
            this.label7_manageCat.TabIndex = 15;
            this.label7_manageCat.Text = "SELLING";
            // 
            // TextBox_name
            // 
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.Location = new System.Drawing.Point(106, 86);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.Size = new System.Drawing.Size(151, 20);
            this.TextBox_name.TabIndex = 3;
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seller.ForeColor = System.Drawing.Color.White;
            this.label_seller.Location = new System.Drawing.Point(10, 78);
            this.label_seller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(59, 28);
            this.label_seller.TabIndex = 2;
            this.label_seller.Text = "Name";
            // 
            // button8_logout
            // 
            this.button8_logout.BackColor = System.Drawing.SystemColors.Control;
            this.button8_logout.FlatAppearance.BorderSize = 0;
            this.button8_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8_logout.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8_logout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8_logout.Location = new System.Drawing.Point(1, 567);
            this.button8_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button8_logout.Name = "button8_logout";
            this.button8_logout.Size = new System.Drawing.Size(105, 82);
            this.button8_logout.TabIndex = 26;
            this.button8_logout.Text = "Logout";
            this.button8_logout.UseVisualStyleBackColor = false;
            this.button8_logout.Click += new System.EventHandler(this.button8_logout_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 650);
            this.Controls.Add(this.button8_logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_price;
        private System.Windows.Forms.TextBox TextBox_qty;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Label label7_manageCat;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Button button8_logout;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label seller_name;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button1_refresh;
        private System.Windows.Forms.DataGridView dataGridView_sellsList;
        private System.Windows.Forms.Button button1_Add;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_id;
    }
}