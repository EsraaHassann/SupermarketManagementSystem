
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_sellList = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_seller = new System.Windows.Forms.Label();
            this.DataGridView_product = new System.Windows.Forms.DataGridView();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_manageProducts = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.Control;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_logout.Location = new System.Drawing.Point(-23, 687);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(175, 64);
            this.button_logout.TabIndex = 31;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click_1);
            // 
            // textBox_qty
            // 
            this.textBox_qty.ForeColor = System.Drawing.Color.Black;
            this.textBox_qty.Location = new System.Drawing.Point(189, 230);
            this.textBox_qty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(265, 22);
            this.textBox_qty.TabIndex = 19;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.White;
            this.Quantity.Location = new System.Drawing.Point(47, 220);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(101, 33);
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
            this.panel1.Location = new System.Drawing.Point(160, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 764);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(764, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "BillId";
            // 
            // textBox_id
            // 
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.Location = new System.Drawing.Point(844, 362);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(132, 22);
            this.textBox_id.TabIndex = 29;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.Location = new System.Drawing.Point(903, 304);
            this.label_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(40, 33);
            this.label_amount.TabIndex = 28;
            this.label_amount.Text = "Ks";
            this.label_amount.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(656, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sells List";
            // 
            // dataGridView_sellList
            // 
            this.dataGridView_sellList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_sellList.ColumnHeadersHeight = 24;
            this.dataGridView_sellList.Location = new System.Drawing.Point(460, 407);
            this.dataGridView_sellList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_sellList.Name = "dataGridView_sellList";
            this.dataGridView_sellList.RowHeadersWidth = 51;
            this.dataGridView_sellList.Size = new System.Drawing.Size(713, 235);
            this.dataGridView_sellList.StandardTab = true;
            this.dataGridView_sellList.TabIndex = 25;
            this.dataGridView_sellList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sellList_CellContentClick);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(331, 352);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(125, 44);
            this.button_refresh.TabIndex = 24;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(84, 352);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(215, 43);
            this.comboBox_category.TabIndex = 23;
            this.comboBox_category.Text = "Select Category";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(927, 36);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(67, 33);
            this.label_date.TabIndex = 22;
            this.label_date.Text = "Date:";
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seller.ForeColor = System.Drawing.Color.White;
            this.label_seller.Location = new System.Drawing.Point(20, 30);
            this.label_seller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(127, 33);
            this.label_seller.TabIndex = 21;
            this.label_seller.Text = "SellerName";
            // 
            // DataGridView_product
            // 
            this.DataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_product.ColumnHeadersHeight = 24;
            this.DataGridView_product.Location = new System.Drawing.Point(84, 407);
            this.DataGridView_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView_product.Name = "DataGridView_product";
            this.DataGridView_product.RowHeadersWidth = 51;
            this.DataGridView_product.Size = new System.Drawing.Size(348, 288);
            this.DataGridView_product.StandardTab = true;
            this.DataGridView_product.TabIndex = 20;
            this.DataGridView_product.Click += new System.EventHandler(this.DataGridView_product_Click);
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
            this.dataGridView_order.Location = new System.Drawing.Point(464, 74);
            this.dataGridView_order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.Size = new System.Drawing.Size(713, 206);
            this.dataGridView_order.StandardTab = true;
            this.dataGridView_order.TabIndex = 16;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            this.ProdId.Width = 125;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 125;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Width = 125;
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // label_manageProducts
            // 
            this.label_manageProducts.AutoSize = true;
            this.label_manageProducts.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageProducts.ForeColor = System.Drawing.Color.White;
            this.label_manageProducts.Location = new System.Drawing.Point(451, 5);
            this.label_manageProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_manageProducts.Name = "label_manageProducts";
            this.label_manageProducts.Size = new System.Drawing.Size(117, 48);
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
            this.button_Print.Location = new System.Drawing.Point(1052, 650);
            this.button_Print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(125, 53);
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
            this.button_add.Location = new System.Drawing.Point(1048, 343);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(125, 53);
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
            this.button_addOrder.Location = new System.Drawing.Point(308, 274);
            this.button_addOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(148, 53);
            this.button_addOrder.TabIndex = 10;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.UseVisualStyleBackColor = false;
            this.button_addOrder.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.ForeColor = System.Drawing.Color.Black;
            this.textBox_price.Location = new System.Drawing.Point(189, 160);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(265, 22);
            this.textBox_price.TabIndex = 5;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(47, 150);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(64, 33);
            this.price.TabIndex = 4;
            this.price.Text = "price";
            // 
            // TextBox_name
            // 
            this.TextBox_name.AcceptsReturn = true;
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.Location = new System.Drawing.Point(189, 102);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.Size = new System.Drawing.Size(265, 22);
            this.TextBox_name.TabIndex = 3;
            this.TextBox_name.TextChanged += new System.EventHandler(this.TextBox_name_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(47, 92);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 33);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(1376, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "X";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 752);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SellingForm";
            this.Text = "SellingFrom1";
            this.Load += new System.EventHandler(this.SellingFrom1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
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