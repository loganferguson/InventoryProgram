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
        public AddPartForm()
        {
            InitializeComponent();
        }

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
                tbCompanyName.Visible = true;
                lbCompanyName.Visible = true;
                tbMachineID.Visible = false;
                lbMachineID.Visible = false;
            }
        }
    }
}
