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
    public partial class ModifyProductForm : Form
    {

        public mainForm mainform;
        public Product product;
        public ModifyProductForm(mainForm main, Product p)
        {
            product = p;
            mainform = main;
            InitializeComponent();
            InitializeDgvCandidateParts();
            InitializeDgvAssociatedParts();
        }

        public void InitializeDgvCandidateParts()
        {
            var source = new BindingSource();
            source.DataSource = Inventory.AllParts;
            dgvCandidateParts.DataSource = source;
        }
        public void InitializeDgvAssociatedParts()
        {
            var parts = new BindingSource();
            parts.DataSource = product.AssociatedParts;
            dgvAssociatedParts.DataSource = parts;
        }

        private void SaveModProductButton_Click(object sender, EventArgs e)
        {
            Inventory.UpdateProduct(this, mainform);
        }

        private void AddCandidateButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvCandidateParts.SelectedRows)
            {
                
                product.AddAssociatedPart(row, product, this);
            }
        }
    }
}
