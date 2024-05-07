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
        }
    }
 }
