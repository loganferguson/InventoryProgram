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

            //Converting string values to decimal/int.

            decimal partPrice = decimal.Parse(tbPriceCost.Text); //Price
            int partMin = int.Parse(tbMin.Text); //Min
            int partMax = int.Parse(tbMax.Text); //Max
            int partInventory = int.Parse(tbInventory.Text); //Inventory


            //Checking if InHouse part.

            if (rdInHouse.Checked)
            {

                Inhouse inhousePart = new Inhouse();
                if (Inventory.AllParts == null)
                {
                    inhousePart.PartID = 1;
                }
                else
                {
                    inhousePart.PartID = Inventory.AllParts.Count + 1;
                }
                inhousePart.PartName = tbPartName.Text;
                inhousePart.Price = partPrice;
                inhousePart.Min = partMin;
                inhousePart.Max = partMax;
                inhousePart.InStock = partInventory;
                int machine = int.Parse(tbMachineID.Text);
                inhousePart.MachineID = machine;

                Inventory.AllParts.Add(inhousePart);

                object[] row = new object[]
                {
                    inhousePart.PartID.ToString(),
                    inhousePart.PartName,
                    inhousePart.InStock.ToString(),
                    inhousePart.Price.ToString(),
                    inhousePart.Min.ToString(),
                    inhousePart.Max.ToString()
                };

                mainform.dgvParts.Rows.Add(row);
                this.Close();
            }


        }

        private void btCancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
