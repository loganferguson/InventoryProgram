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

        private void SearchAssociatedButton_Click(object sender, EventArgs e)
        {

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
            Inventory inventory = new Inventory(mainform);
            inventory.AddProduct(this, product);
            this.Close();
            mainform.InitializeProductDataGridView();
        }
    }
}
