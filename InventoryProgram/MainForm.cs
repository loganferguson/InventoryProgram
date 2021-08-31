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
            var partSource = new BindingSource();
            partSource.DataSource = Inventory.AllParts;
            dgvParts.DataSource = partSource;
            dgvParts.Columns[6].Visible = false;
        }

        public void InitializeProductDataGridView()
        {
            var productSource = new BindingSource();
            productSource.DataSource = Inventory.Products;
            dgvProducts.DataSource = productSource;
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

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvParts.SelectedRows)
            {
                string rowID = row.Cells[1].Value.ToString();
                dgvParts.Rows.RemoveAt(row.Index);
                //Inventory.AllParts.RemoveAll(x => x.PartID == int.Parse(row.Cells[0].Value.ToString()));
            }
            Console.WriteLine(Inventory.AllParts.Count);
        }
    }
}
