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
            //Exception Handling:
            if (!IsValid())
            {
                return;
            }
            
            Inventory.UpdateProduct(this, mainform);
        }

        private void AddCandidateButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvCandidateParts.SelectedRows)
            {
                
                product.AddAssociatedPart(row, product, this);
            }
        }

        public bool IsValid()
        {

            if (
                string.IsNullOrEmpty(tbModProductName.Text) ||
                string.IsNullOrEmpty(tbModProductName.Text) ||
                string.IsNullOrEmpty(tbModProductName.Text) ||
                string.IsNullOrEmpty(tbModProductName.Text) ||
                string.IsNullOrEmpty(tbModProductName.Text)
                )
            {
                MessageBox.Show("Wait! One or more of the fields was not completed.");
                return false;
            }
            else if (!decimal.TryParse(tbModProductPrice.Text, out decimal d))
            {
                MessageBox.Show("Wait! The product price field must be a numerical value.");
                return false;
            }
            else if (!int.TryParse(tbModProductInventory.Text, out int i))
            {
                MessageBox.Show("Wait! The inventory field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbModProductMin.Text, out int j))
            {
                MessageBox.Show("Wait! The inventory minimum field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbModProductMax.Text, out int k))
            {
                MessageBox.Show("Wait! The inventory maximum field must be a whole number value.");
                return false;
            }

            int stock = int.Parse(tbModProductInventory.Text);
            int max = int.Parse(tbModProductMax.Text);
            int min = int.Parse(tbModProductMin.Text);
            if (stock < min || stock > max)
            {
                MessageBox.Show("Wait! Product inventory must be greater than \"Min\" and less than \"Max.\"");
                return false;
            }
            if (max < min)
            {
                MessageBox.Show("Wait! Maximum cannot be less than minimum.");
            }
            return true;
        }

        private void DeleteAssociatedButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove this part?";
            string boxTitle = "Delete Part";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, boxTitle, buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow row in dgvAssociatedParts.SelectedRows)
            {
                product.RemoveAssociatedPart(row, this);
                InitializeDgvAssociatedParts();
            }
            
        }
    }
}
