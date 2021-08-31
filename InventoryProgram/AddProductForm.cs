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
    public partial class AddProductForm : Form
    {
        public mainForm mainform;

        public AddProductForm(mainForm main)
        {
            mainform = main;
            InitializeComponent();
            InitializeCandidateGridView();
            InitializeAssociatedGridView();
            
        }

        public void InitializeCandidateGridView()
        {
            var source = new BindingSource();
            source.DataSource = Inventory.AllParts;
            dgvCandidateParts.DataSource = source;
            dgvCandidateParts.Columns[6].Visible = false;
        }

        public void InitializeAssociatedGridView()
        {
            dgvAssociatedParts.ColumnCount = 6;
            dgvAssociatedParts.ColumnHeadersVisible = true;
            dgvAssociatedParts.ReadOnly = true;

            dgvAssociatedParts.Columns[0].Name = "PartID";
            dgvAssociatedParts.Columns[1].Name = "Name";
            dgvAssociatedParts.Columns[2].Name = "Inventory";
            dgvAssociatedParts.Columns[3].Name = "Price";
            dgvAssociatedParts.Columns[4].Name = "Min";
            dgvAssociatedParts.Columns[5].Name = "Max";
        }

        private void SearchAssociatedButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
