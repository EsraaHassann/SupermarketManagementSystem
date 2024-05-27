namespace SupermarketManagementSystem
{
    partial class ProductForm
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
            this.button_selling = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_seller = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.label_manageProducts = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.button8_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // button_selling
            // 
            this.button_selling.BackColor = System.Drawing.SystemColors.Control;
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_selling.Location = new System.Drawing.Point(8, 197);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(140, 52);
            this.button_selling.TabIndex = 24;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = false;
            // 
            // button_category
            // 
            this.button_category.BackColor = System.Drawing.SystemColors.Control;
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_category.Location = new System.Drawing.Point(8, 121);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(140, 52);
            this.button_category.TabIndex = 23;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = false;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_seller
            // 
            this.button_seller.BackColor = System.Drawing.SystemColors.Control;
            this.button_seller.FlatAppearance.BorderSize = 0;
            this.button_seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_seller.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_seller.Location = new System.Drawing.Point(8, 40);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(140, 52);
            this.button_seller.TabIndex = 22;
            this.button_seller.Text = "Seller";
            this.button_seller.UseVisualStyleBackColor = false;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(1071, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_search);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.textBox_qty);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.dataGridView_products);
            this.panel1.Controls.Add(this.label_manageProducts);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Location = new System.Drawing.Point(159, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 611);
            this.panel1.TabIndex = 20;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(703, 59);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(105, 43);
            this.button_refresh.TabIndex = 25;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_search
            // 
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Location = new System.Drawing.Point(481, 67);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(200, 37);
            this.comboBox_search.TabIndex = 23;
            this.comboBox_search.Text = "Select Category";
            this.comboBox_search.SelectionChangeCommitted += new System.EventHandler(this.comboBox_search_SelectionChangeCommitted);
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(142, 285);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(200, 37);
            this.comboBox_category.TabIndex = 21;
            this.comboBox_category.Text = "Select Category";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(13, 285);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(103, 33);
            this.category.TabIndex = 20;
            this.category.Text = "Category";
            // 
            // textBox_qty
            // 
            this.textBox_qty.ForeColor = System.Drawing.Color.Black;
            this.textBox_qty.Location = new System.Drawing.Point(142, 241);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(200, 33);
            this.textBox_qty.TabIndex = 19;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.White;
            this.Quantity.Location = new System.Drawing.Point(13, 241);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(101, 33);
            this.Quantity.TabIndex = 18;
            this.Quantity.Text = "Quantity";
            // 
            // textBox_id
            // 
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.Location = new System.Drawing.Point(142, 108);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(200, 33);
            this.textBox_id.TabIndex = 17;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_products.ColumnHeadersHeight = 24;
            this.dataGridView_products.Location = new System.Drawing.Point(366, 108);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowHeadersWidth = 51;
            this.dataGridView_products.Size = new System.Drawing.Size(550, 490);
            this.dataGridView_products.StandardTab = true;
            this.dataGridView_products.TabIndex = 16;
            //this.dataGridView_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_products_CellContentClick);
            //this.dataGridView_products.Click += new System.EventHandler(this.dataGridView_products_Click);
            // 
            // label_manageProducts
            // 
            this.label_manageProducts.AutoSize = true;
            this.label_manageProducts.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageProducts.ForeColor = System.Drawing.Color.White;
            this.label_manageProducts.Location = new System.Drawing.Point(338, 4);
            this.label_manageProducts.Name = "label_manageProducts";
            this.label_manageProducts.Size = new System.Drawing.Size(315, 48);
            this.label_manageProducts.TabIndex = 15;
            this.label_manageProducts.Text = "MANAGE PRODUCTS";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(248, 340);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 43);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(133, 340);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(94, 43);
            this.button_Update.TabIndex = 11;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(24, 340);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(94, 43);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.ForeColor = System.Drawing.Color.Black;
            this.textBox_price.Location = new System.Drawing.Point(142, 196);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(200, 33);
            this.textBox_price.TabIndex = 5;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(13, 196);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(64, 33);
            this.price.TabIndex = 4;
            this.price.Text = "price";
            // 
            // textBox_name
            // 
            this.textBox_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_name.Location = new System.Drawing.Point(142, 150);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 33);
            this.textBox_name.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(13, 152);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 33);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(13, 108);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(38, 33);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // button8_logout
            // 
            this.button8_logout.BackColor = System.Drawing.SystemColors.Control;
            this.button8_logout.FlatAppearance.BorderSize = 0;
            this.button8_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8_logout.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8_logout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8_logout.Location = new System.Drawing.Point(8, 582);
            this.button8_logout.Name = "button8_logout";
            this.button8_logout.Size = new System.Drawing.Size(140, 52);
            this.button8_logout.TabIndex = 25;
            this.button8_logout.Text = "Logout";
            this.button8_logout.UseVisualStyleBackColor = false;
            this.button8_logout.Click += new System.EventHandler(this.button8_logout_Click);
            this.button8_logout.MouseEnter += new System.EventHandler(this.button8_logout_MouseEnter);
            this.button8_logout.MouseLeave += new System.EventHandler(this.button8_logout_MouseLeave);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button8_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.Label label_manageProducts;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button8_logout;
    }
}