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
    
    public partial class AddPartForm : Form
    {
        public mainForm mainform;

        public AddPartForm(mainForm main)
        {
            InitializeComponent();
            mainform = main;
        }

        // RADIO BUTTON SWITCH VIEW //
        private void rdInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInHouse.Checked)
            {
                tbMachineID.Visible = true;
                lbMachineID.Visible = true;
                tbCompanyName.Visible = false;
                lbCompanyName.Visible = false;
            }
        }

        private void rdOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOutsourced.Checked)
            {
                tbCompanyName.Visible = true; //text box
                lbCompanyName.Visible = true; //label
                tbMachineID.Visible = false;  //text box
                lbMachineID.Visible = false;  //label
            }
        }


        // SUBMIT ADD PART FORM //
        private void btSavePart_Click(object sender, EventArgs e)
        {
            if (!IsValidPart())
            {
                return;
            }

            Inventory i = new Inventory(mainform);
            i.addPart(this);

        }

        private void btCancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsValidPart()
        {

            if (
                (rdInHouse.Checked == false && rdOutsourced.Checked == false) ||
                string.IsNullOrEmpty(tbPartName.Text) ||
                string.IsNullOrEmpty(tbInventory.Text) ||
                string.IsNullOrEmpty(tbPriceCost.Text) ||
                string.IsNullOrEmpty(tbMin.Text) ||
                string.IsNullOrEmpty(tbMax.Text)
                )
            {
                MessageBox.Show("Wait! One or more of the fields was not completed.");
                return false;
            }
            else if (!decimal.TryParse(tbPriceCost.Text, out decimal d))
            {
                MessageBox.Show("Wait! The Part price field must be a numerical value.");
                return false;
            }
            else if (!int.TryParse(tbInventory.Text, out int i))
            {
                MessageBox.Show("Wait! The inventory field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbMin.Text, out int j))
            {
                MessageBox.Show("Wait! The inventory minimum field must be a whole number value.");
                return false;
            }
            else if (!int.TryParse(tbMax.Text, out int k))
            {
                MessageBox.Show("Wait! The inventory maximum field must be a whole number value.");
                return false;
            }
            else if (rdInHouse.Checked == true && !int.TryParse(tbMachineID.Text, out int l))
            {
                MessageBox.Show("Wait! The Machine ID field must be a whole number value.");
                return false;
            }
            else if (rdOutsourced.Checked == true && String.IsNullOrEmpty(tbCompanyName.Text))
            {
                MessageBox.Show("Wait! Outsourced parts must have a company name.");
                return false;
            }

            int stock = int.Parse(tbInventory.Text);
            int max = int.Parse(tbMax.Text);
            int min = int.Parse(tbMin.Text);
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
