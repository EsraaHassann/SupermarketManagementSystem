using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public interface IUserInterface
    {
        void ShowMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
        void ClearTextBoxes();
        void UpdateDataGridView(DataTable table);
    }

}
