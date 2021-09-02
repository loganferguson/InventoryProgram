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
            var part = (Inventory.AllParts.Where
                    (x => x.PartID == int.Parse(tbModPartID.Text))).FirstOrDefault();

            if(part is Outsourced && rbModOutSourced.Checked) 
            {
                var outPart = part as Outsourced;
                outPart.PartName = tbModPartName.Text;
                outPart.InStock = int.Parse(tbModPartInventory.Text);
                outPart.Price = int.Parse(tbModPartPrice.Text);
                outPart.Min = int.Parse(tbModPartMin.Text);
                outPart.Max = int.Parse(tbModPartMax.Text);
                outPart.CompanyName = tbModCompanyName.Text;
                this.Close();
                mainform.InitializePartDataGridView();
            }
            else if (part is Inhouse && rbModInHouse.Checked)
            {
                var inPart = part as Inhouse;
                inPart.PartName = tbModPartName.Text;
                inPart.InStock = int.Parse(tbModPartInventory.Text);
                inPart.Price = int.Parse(tbModPartPrice.Text);
                inPart.Min = int.Parse(tbModPartMin.Text);
                inPart.Max = int.Parse(tbModPartMax.Text);
                inPart.MachineID = int.Parse(tbModMachineID.Text);
                this.Close();
                mainform.InitializePartDataGridView();
            }

            if (rbModOutSourced.Checked)
            {
                

                
                
            }
            else if (rbModInHouse.Checked)
            {

            }
            
            
        }
    }
}
