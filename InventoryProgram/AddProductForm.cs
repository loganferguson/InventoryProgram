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
        public Product product;

        public AddProductForm(mainForm main)
        {
            Product p = new Product(this);
            product = p;
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
        }

        public void InitializeAssociatedGridView()
        {
            List<Part> list = new List<Part>();
            list = product.AssociatedParts;
            var source = new BindingSource();
            source.DataSource = list;
            dgvAssociatedParts.DataSource = source;
        }


        private void CancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCandidateButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvCandidateParts.SelectedRows)
            {
                product.AddAssociatedPart(row, product);
            }
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            if (!IsValidProduct())
            {
                return;
            }
            Inventory inventory = new Inventory(mainform);
            inventory.AddProduct(this, product);
            this.Close();
            mainform.InitializeProductDataGridView();
        }
        public bool IsValidProduct()
        {
            
            if (
                string.IsNullOrEmpty(tbProductName.Text) ||
                string.IsNullOrEmpty(tbProductName.Text) ||
                string.IsNullOrEmpty(tbProductName.Text) ||
                string.IsNullOrEmpty(tbProductName.Text) ||
                string.IsNullOrEmpty(tbProductName.Text)
                )
            {
                MessageBox.Show("Wait! One or more of the fields was not completed.");
                return false;
            }
            else if (!decimal.TryParse(tbProductPrice.Text, out decimal d))
            {
                MessageBox.Show("Wait! The product price field must be a numerical value.");
                return false;
            }
            else if (!int.TryParse(tbProductInventory.Text, out int i))
            {
                MessageBox.Show("Wait! The inventory field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbProductMin.Text, out int j))
            {
                MessageBox.Show("Wait! The inventory minimum field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbProductMax.Text, out int k))
            {
                MessageBox.Show("Wait! The inventory maximum field must be a whole number value.");
                return false;
            }

            int stock = int.Parse(tbProductInventory.Text);
            int max = int.Parse(tbProductMax.Text);
            int min = int.Parse(tbProductMin.Text);
            if (stock < min || stock > max)
            {
                MessageBox.Show("Wait! Product inventory must be greater than \"Min\" and less than \"Max.\"");
                return false;
            }
            if(max < min)
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
            }
            
        }

        private void SearchCandidateButton_Click(object sender, EventArgs e)
        {
            product.LookupCandidatePart(this);
        }
    }
}
