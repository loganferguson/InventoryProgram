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
    public partial class ModifyPartForm : Form
    {
        public mainForm mainform;

        public ModifyPartForm(mainForm main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void rbModInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModInHouse.Checked)
            {
                tbModMachineID.Visible = true;
                lbModMachineID.Visible = true;
                tbModCompanyName.Visible = false;
                lbModCompanyName.Visible = false;
            }
        }

        private void rbModOutSourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModOutSourced.Checked)
            {
                tbModCompanyName.Visible = true; //text box
                lbModCompanyName.Visible = true; //label
                tbModMachineID.Visible = false;  //text box
                lbModMachineID.Visible = false;  //label
            }
        }

        private void CancelModPartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveModPartButton_Click(object sender, EventArgs e)
        {
            if (!IsValidPart())
            {
                return;
            }
            Inventory i = new Inventory(mainform);
            i.updatePart(this);    
        }

        public bool IsValidPart()
        {

            if (
                string.IsNullOrEmpty(tbModPartName.Text) ||
                string.IsNullOrEmpty(tbModPartInventory.Text) ||
                string.IsNullOrEmpty(tbModPartPrice.Text) ||
                string.IsNullOrEmpty(tbModPartMin.Text) ||
                string.IsNullOrEmpty(tbModPartMax.Text)
                )
            {
                MessageBox.Show("Wait! One or more of the fields was not completed.");
                return false;
            }
            else if (!decimal.TryParse(tbModPartPrice.Text, out decimal d))
            {
                MessageBox.Show("Wait! The Part price field must be a numerical value.");
                return false;
            }
            else if (!int.TryParse(tbModPartInventory.Text, out int i))
            {
                MessageBox.Show("Wait! The inventory field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbModPartMin.Text, out int j))
            {
                MessageBox.Show("Wait! The inventory minimum field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbModPartMax.Text, out int k))
            {
                MessageBox.Show("Wait! The inventory maximum field must be a whole number value.");
                return false;
            }
            else if (rbModInHouse.Checked == true && !int.TryParse(tbModMachineID.Text, out int l))
            {
                MessageBox.Show("Wait! The Machine ID field must be a whole number value.");
                return false;
            }
            else if (rbModOutSourced.Checked == true && String.IsNullOrEmpty(tbModCompanyName.Text))
            {
                MessageBox.Show("Wait! Outsourced parts must have a company name.");
                return false;
            }

            int stock = int.Parse(tbModPartInventory.Text);
            int max = int.Parse(tbModPartMax.Text);
            int min = int.Parse(tbModPartMin.Text);
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
    }
}
