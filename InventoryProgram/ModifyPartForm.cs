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
        public ModifyPartForm()
        {
            InitializeComponent();
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
    }
}
