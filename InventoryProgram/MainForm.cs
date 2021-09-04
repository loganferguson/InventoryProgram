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
        }

        public void InitializeProductDataGridView()
        {
            var productSource = new BindingSource();
            productSource.DataSource = Inventory.Products;
            dgvProducts.DataSource = productSource;
        }

        public void SearchPartButton_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory(this);
            i.LookupPart(this);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(this);
            
            form.Show();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory(this);
            i.DeletePart();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            ModifyPartForm modForm = new ModifyPartForm(this);
            foreach(DataGridViewRow row in dgvParts.SelectedRows)
            {
                if(row.DataBoundItem is Outsourced)
                {
                    modForm.rbModOutSourced.Checked = true;
                    Outsourced part = Inventory.AllParts.Where(x => x.PartID == int.Parse(row.Cells[0].Value.ToString())).First() as Outsourced;
                    modForm.tbModPartID.Text = part.PartID.ToString();
                    modForm.tbModPartName.Text = part.PartName.ToString();
                    modForm.tbModPartInventory.Text = part.InStock.ToString();
                    modForm.tbModPartPrice.Text = part.Price.ToString();
                    modForm.tbModPartMin.Text = part.Min.ToString();
                    modForm.tbModPartMax.Text = part.Max.ToString();
                    modForm.tbModCompanyName.Text = part.CompanyName.ToString();
                }
                else if (row.DataBoundItem is Inhouse)
                {
                    modForm.rbModInHouse.Checked = true;
                    Inhouse part = Inventory.AllParts.Where(x => x.PartID == int.Parse(row.Cells[0].Value.ToString())).First() as Inhouse;
                    modForm.tbModPartID.Text = part.PartID.ToString();
                    modForm.tbModPartName.Text = part.PartName.ToString();
                    modForm.tbModPartInventory.Text = part.InStock.ToString();
                    modForm.tbModPartPrice.Text = part.Price.ToString();
                    modForm.tbModPartMin.Text = part.Min.ToString();
                    modForm.tbModPartMax.Text = part.Max.ToString();
                    modForm.tbModMachineID.Text = part.MachineID.ToString();
                }
            }
            modForm.Show();
        }
    }
}
