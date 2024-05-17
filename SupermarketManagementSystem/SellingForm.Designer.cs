
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
            this.button_logout = new System.Windows.Forms.Button();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.label_manageProducts = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_product = new System.Windows.Forms.DataGridView();
            this.label_seller = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_sellList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.Control;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_logout.Location = new System.Drawing.Point(-17, 558);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(131, 52);
            this.button_logout.TabIndex = 31;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click_1);
            // 
            // textBox_qty
            // 
            this.textBox_qty.ForeColor = System.Drawing.Color.Black;
            this.textBox_qty.Location = new System.Drawing.Point(142, 187);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(200, 20);
            this.textBox_qty.TabIndex = 19;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.White;
            this.Quantity.Location = new System.Drawing.Point(35, 179);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(82, 28);
            this.Quantity.TabIndex = 18;
            this.Quantity.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label_amount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_sellList);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Controls.Add(this.DataGridView_product);
            this.panel1.Controls.Add(this.textBox_qty);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.label_manageProducts);
            this.panel1.Controls.Add(this.button_Print);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_addOrder);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(120, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 621);
            this.panel1.TabIndex = 26;
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
            this.Total});
            this.dataGridView_order.Location = new System.Drawing.Point(348, 60);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.Size = new System.Drawing.Size(535, 167);
            this.dataGridView_order.StandardTab = true;
            this.dataGridView_order.TabIndex = 16;
            // 
            // label_manageProducts
            // 
            this.label_manageProducts.AutoSize = true;
            this.label_manageProducts.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageProducts.ForeColor = System.Drawing.Color.White;
            this.label_manageProducts.Location = new System.Drawing.Point(338, 4);
            this.label_manageProducts.Name = "label_manageProducts";
            this.label_manageProducts.Size = new System.Drawing.Size(96, 39);
            this.label_manageProducts.TabIndex = 15;
            this.label_manageProducts.Text = "Selling\r\n";
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Print.FlatAppearance.BorderSize = 0;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.ForeColor = System.Drawing.Color.White;
            this.button_Print.Location = new System.Drawing.Point(789, 528);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(94, 43);
            this.button_Print.TabIndex = 12;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(786, 279);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 43);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // button_addOrder
            // 
            this.button_addOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_addOrder.FlatAppearance.BorderSize = 0;
            this.button_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOrder.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addOrder.ForeColor = System.Drawing.Color.White;
            this.button_addOrder.Location = new System.Drawing.Point(231, 223);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(111, 43);
            this.button_addOrder.TabIndex = 10;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.UseVisualStyleBackColor = false;
            this.button_addOrder.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.ForeColor = System.Drawing.Color.Black;
            this.textBox_price.Location = new System.Drawing.Point(142, 130);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(200, 20);
            this.textBox_price.TabIndex = 5;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(35, 122);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 28);
            this.price.TabIndex = 4;
            this.price.Text = "price";
            // 
            // TextBox_name
            // 
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.Location = new System.Drawing.Point(142, 83);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.Size = new System.Drawing.Size(200, 20);
            this.TextBox_name.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(35, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 28);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(1032, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "X";
            // 
            // DataGridView_product
            // 
            this.DataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_product.ColumnHeadersHeight = 24;
            this.DataGridView_product.Location = new System.Drawing.Point(63, 331);
            this.DataGridView_product.Name = "DataGridView_product";
            this.DataGridView_product.RowHeadersWidth = 51;
            this.DataGridView_product.Size = new System.Drawing.Size(261, 234);
            this.DataGridView_product.StandardTab = true;
            this.DataGridView_product.TabIndex = 20;
            this.DataGridView_product.Click += new System.EventHandler(this.DataGridView_product_Click);
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seller.ForeColor = System.Drawing.Color.White;
            this.label_seller.Location = new System.Drawing.Point(15, 24);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(105, 28);
            this.label_seller.TabIndex = 21;
            this.label_seller.Text = "SellerName";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(695, 29);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(55, 28);
            this.label_date.TabIndex = 22;
            this.label_date.Text = "Date:";
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(63, 286);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(162, 36);
            this.comboBox_category.TabIndex = 23;
            this.comboBox_category.Text = "Select Category";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(248, 286);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(94, 36);
            this.button_refresh.TabIndex = 24;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_sellList
            // 
            this.dataGridView_sellList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_sellList.ColumnHeadersHeight = 24;
            this.dataGridView_sellList.Location = new System.Drawing.Point(345, 331);
            this.dataGridView_sellList.Name = "dataGridView_sellList";
            this.dataGridView_sellList.RowHeadersWidth = 51;
            this.dataGridView_sellList.Size = new System.Drawing.Size(535, 191);
            this.dataGridView_sellList.StandardTab = true;
            this.dataGridView_sellList.TabIndex = 25;
            this.dataGridView_sellList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sellList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sells List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(492, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.Location = new System.Drawing.Point(677, 247);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(32, 28);
            this.label_amount.TabIndex = 28;
            this.label_amount.Text = "Ks";
            this.label_amount.Click += new System.EventHandler(this.label4_Click);
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
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // textBox_id
            // 
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.Location = new System.Drawing.Point(633, 294);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(573, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "BillId";
            // 
            // SellingFrom1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 611);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingFrom1";
            this.Text = "SellingFrom1";
            this.Load += new System.EventHandler(this.SellingFrom1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Label label_manageProducts;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridView_product;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_sellList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_id;
    }
}