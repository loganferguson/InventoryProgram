using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPartForm form = new AddPartForm(this);
            form.Show();
        }

        public void InitializeDataGridView()
        {
            dgvParts.ColumnCount = 6;
            dgvParts.ColumnHeadersVisible = true;
            dgvParts.ReadOnly = true;

            dgvParts.Columns[0].Name = "PartID";
            dgvParts.Columns[1].Name = "Name";
            dgvParts.Columns[2].Name = "Inventory";
            dgvParts.Columns[3].Name = "Price";
            dgvParts.Columns[4].Name = "Min";
            dgvParts.Columns[5].Name = "Max";

        }

    }
}
