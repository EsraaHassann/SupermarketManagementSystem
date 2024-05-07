using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    partial class CategoryForm
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
            this.SuspendLayout();
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);

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

