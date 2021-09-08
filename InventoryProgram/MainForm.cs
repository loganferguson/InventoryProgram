﻿using System;
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
            SeedData();
            InitializePartDataGridView();
            InitializeProductDataGridView();
        }

        public void SeedData()
        {
            Outsourced outPart = new Outsourced
            {
                PartID = 1,
                PartName = "Chain",
                InStock = 23,
                Price = 35,
                Min = 10,
                Max = 40,
                CompanyName = "Dobis Company"
            };
            Inhouse inPart = new Inhouse
            {
                PartID = 2,
                PartName = "Wheel",
                InStock = 47,
                Price = 50,
                Min = 10,
                Max = 80,
                MachineID = 440125
            };
            Inventory.AllParts.Add(outPart);
            Inventory.AllParts.Add(inPart);
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
            string message = "Are you sure you want to remove this part?";
            string boxTitle = "Delete Part";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, boxTitle, buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            Inventory i = new Inventory(this);
            i.DeletePart();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            
            ModifyPartForm modForm = new ModifyPartForm(this);
            foreach (DataGridViewRow row in dgvParts.SelectedRows)
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

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow row in dgvProducts.SelectedRows)
            {
                var p = Inventory.Products.Where(x => x.ProductID == int.Parse(row.Cells[0].Value.ToString())).First();
                ModifyProductForm form = new ModifyProductForm(this, p);
                form.tbModProductID.Text = row.Cells[0].Value.ToString();
                form.tbModProductName.Text = row.Cells[1].Value.ToString();
                form.tbModProductPrice.Text = row.Cells[2].Value.ToString();
                form.tbModProductInventory.Text = row.Cells[3].Value.ToString();             
                form.tbModProductMin.Text = row.Cells[4].Value.ToString();
                form.tbModProductMax.Text = row.Cells[5].Value.ToString();

                form.Show();
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove this product?";
            string boxTitle = "Delete Product";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, boxTitle, buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            Inventory i = new Inventory(this);
            i.RemoveProduct(this);
        }
    }
}
