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
    public partial class ModifyProductForm : Form
    {

        public mainForm mainform;
        public Product product;
        public ModifyProductForm(mainForm main, Product p)
        {
            product = p;
            mainform = main;
            InitializeComponent();
            InitializeDgvAssociatedParts();
        }

        public void InitializeDgvAssociatedParts()
        {
            var parts = new BindingSource();
            parts.DataSource = product.AssociatedParts;
            dgvModAssociatedParts.DataSource = parts;
        }
    }
}
