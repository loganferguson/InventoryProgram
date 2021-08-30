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
            InitializePartDataGridView();
            InitializeProductDataGridView();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPartForm form = new AddPartForm(this);
            form.Show();
        }

        public void InitializePartDataGridView()
        {
            //dgvParts.ColumnCount = 6;
            //dgvParts.ColumnHeadersVisible = true;
            //dgvParts.ReadOnly = true;

            //dgvParts.Columns[0].Name = "PartID";
            //dgvParts.Columns[1].Name = "Name";
            //dgvParts.Columns[2].Name = "Inventory";
            //dgvParts.Columns[3].Name = "Price";
            //dgvParts.Columns[4].Name = "Min";
            //dgvParts.Columns[5].Name = "Max";

            var source = new BindingSource();
            source.DataSource = Inventory.AllParts;
            dgvParts.DataSource = source;
            dgvParts.Columns[6].Visible = false;

        }

        public void InitializeProductDataGridView()
        {
            dgvProducts.ColumnCount = 6;
            dgvProducts.ColumnHeadersVisible = true;
            dgvProducts.ReadOnly = true;

            dgvProducts.Columns[0].Name = "PartID";
            dgvProducts.Columns[1].Name = "Name";
            dgvProducts.Columns[2].Name = "Inventory";
            dgvProducts.Columns[3].Name = "Price";
            dgvProducts.Columns[4].Name = "Min";
            dgvProducts.Columns[5].Name = "Max";
        }

        public void SearchPartButton_Click(object sender, EventArgs e)
        {
            string searchValue = tbPartSearch.Text;

            if (String.IsNullOrEmpty(searchValue))
            {
                return;
            }

            foreach(DataGridViewRow row in dgvParts.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Contains(searchValue))
                {
                    row.Selected = true;
                }
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(this);
            form.Show();
        }
    }
}
