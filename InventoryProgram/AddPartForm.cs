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

            if (String.IsNullOrEmpty(tbPartName.Text) ||
                String.IsNullOrEmpty(tbPriceCost.Text) ||
                String.IsNullOrEmpty(tbMin.Text) ||
                String.IsNullOrEmpty(tbMax.Text) ||
                String.IsNullOrEmpty(tbInventory.Text)
                )
            {
                MessageBox.Show("One or more fields were not completed.");
                return;
            }

            Inventory i = new Inventory(mainform);
            i.addPart(this);

        }

        private void btCancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
