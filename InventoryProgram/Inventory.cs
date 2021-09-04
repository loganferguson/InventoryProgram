using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public class Inventory
    {
        public mainForm mainform;

        public static List<Part> AllParts = new List<Part>();
        public static List<Product> Products = new List<Product>();

        public Inventory(mainForm main)
        {
            mainform = main;
        }


        //PART METHODS:

        public void addPart(AddPartForm a)
        {
            //Converting string values to decimal/int.

            decimal partPrice = decimal.Parse(a.tbPriceCost.Text); //Price
            int partMin = int.Parse(a.tbMin.Text); //Min
            int partMax = int.Parse(a.tbMax.Text); //Max
            int partInventory = int.Parse(a.tbInventory.Text); //Inventory


            //Checking if InHouse part.

            if (a.rdInHouse.Checked)
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

                inhousePart.PartName = a.tbPartName.Text;
                inhousePart.Price = partPrice;
                inhousePart.Min = partMin;
                inhousePart.Max = partMax;
                inhousePart.InStock = partInventory;
                int machine = int.Parse(a.tbMachineID.Text);
                inhousePart.MachineID = machine;
                Inventory.AllParts.Add(inhousePart);

                Console.WriteLine(Inventory.AllParts.Count);
                mainform.InitializePartDataGridView();
                a.Close();
            }
            else if (a.rdOutsourced.Checked)
            {
                Outsourced outPart = new Outsourced();
                if (Inventory.AllParts == null)
                {
                    outPart.PartID = 1;
                }
                else
                {
                    outPart.PartID = Inventory.AllParts.Count + 1;
                }

                outPart.PartName = a.tbPartName.Text;
                outPart.Price = partPrice;
                outPart.Min = partMin;
                outPart.Max = partMax;
                outPart.InStock = partInventory;
                string company = a.tbCompanyName.Text;
                outPart.CompanyName = company;

                Inventory.AllParts.Add(outPart);
                mainform.InitializePartDataGridView();
                a.Close();
            }
        }

        public void addPart(ModifyPartForm m)
        {
            //Converting string values to decimal/int.

            decimal partPrice = decimal.Parse(m.tbModPartPrice.Text); //Price
            int partMin = int.Parse(m.tbModPartMin.Text); //Min
            int partMax = int.Parse(m.tbModPartMax.Text); //Max
            int partInventory = int.Parse(m.tbModPartInventory.Text); //Inventory


            //Checking if InHouse part.

            if (m.rbModInHouse.Checked)
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

                inhousePart.PartName = m.tbModPartName.Text;
                inhousePart.Price = partPrice;
                inhousePart.Min = partMin;
                inhousePart.Max = partMax;
                inhousePart.InStock = partInventory;
                int machine = int.Parse(m.tbModMachineID.Text);
                inhousePart.MachineID = machine;
                Inventory.AllParts.Add(inhousePart);

                Console.WriteLine(Inventory.AllParts.Count);
                mainform.InitializePartDataGridView();
                m.Close();
            }
            else if (m.rbModOutSourced.Checked)
            {
                Outsourced outPart = new Outsourced();
                if (Inventory.AllParts == null)
                {
                    outPart.PartID = 1;
                }
                else
                {
                    outPart.PartID = Inventory.AllParts.Count + 1;
                }

                outPart.PartName = m.tbModPartName.Text;
                outPart.Price = partPrice;
                outPart.Min = partMin;
                outPart.Max = partMax;
                outPart.InStock = partInventory;
                string company = m.tbModCompanyName.Text;
                outPart.CompanyName = company;

                Inventory.AllParts.Add(outPart);
                mainform.InitializePartDataGridView();
                m.Close();
            }
        }

        public void updatePart(ModifyPartForm m)
        {
            var part = (Inventory.AllParts.Where
                    (x => x.PartID == int.Parse(m.tbModPartID.Text))).FirstOrDefault();

            if (part is Outsourced && m.rbModOutSourced.Checked)
            {
                var outPart = part as Outsourced;
                outPart.PartName = m.tbModPartName.Text;
                outPart.InStock = int.Parse(m.tbModPartInventory.Text);
                outPart.Price = int.Parse(m.tbModPartPrice.Text);
                outPart.Min = int.Parse(m.tbModPartMin.Text);
                outPart.Max = int.Parse(m.tbModPartMax.Text);
                outPart.CompanyName = m.tbModCompanyName.Text;
                m.Close();
                mainform.InitializePartDataGridView();
            }
            else if (part is Inhouse && m.rbModInHouse.Checked)
            {
                var inPart = part as Inhouse;
                inPart.PartName = m.tbModPartName.Text;
                inPart.InStock = int.Parse(m.tbModPartInventory.Text);
                inPart.Price = int.Parse(m.tbModPartPrice.Text);
                inPart.Min = int.Parse(m.tbModPartMin.Text);
                inPart.Max = int.Parse(m.tbModPartMax.Text);
                inPart.MachineID = int.Parse(m.tbModMachineID.Text);
                m.Close();
                mainform.InitializePartDataGridView();
            }

            // Exception for changing part SOURCE in Modify Part form:

            if (part is Outsourced && m.rbModInHouse.Checked)
            {

                addPart(m);
                var o = part as Outsourced;
                DeletePart(o);
                mainform.InitializePartDataGridView();
                
            }
            else if (part is Inhouse && m.rbModOutSourced.Checked)
            {
                addPart(m);
                var i = part as Inhouse;
                DeletePart(i);
                mainform.InitializePartDataGridView();
            }
        }

        public void LookupPart(mainForm m)
        {
            string searchValue = m.tbPartSearch.Text;

            if (String.IsNullOrEmpty(searchValue))
            {
                return;
            }

            foreach (DataGridViewRow row in mainform.dgvParts.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Contains(searchValue))
                {
                    row.Selected = true;
                }
            }
        }

        public void DeletePart(Inhouse inPart)
        {
            Inventory.AllParts.Remove(inPart);
        }
        public void DeletePart(Outsourced outPart)
        {
            Inventory.AllParts.Remove(outPart);
        }
        public void DeletePart()
        {
            foreach (DataGridViewRow row in mainform.dgvParts.SelectedRows)
            {
                string rowID = row.Cells[1].Value.ToString();
                mainform.dgvParts.Rows.RemoveAt(row.Index);
            }
        }

        //PRODUCT METHODS:

        public void AddProduct(AddProductForm p, Product prod)
        {

            if (mainform.dgvProducts.RowCount == 0)
            {
                prod.ProductID = 1;
            }
            else
            {
                prod.ProductID = mainform.dgvProducts.RowCount + 1;
            }

            prod.ProductName = p.tbProductName.Text;
            prod.InStock = int.Parse(p.tbProductInventory.Text.ToString());
            prod.Price = int.Parse(p.tbProductPrice.Text.ToString());
            prod.Min = int.Parse(p.tbProductMin.Text.ToString());
            prod.Max = int.Parse(p.tbProductMax.Text.ToString());

            Products.Add(prod);

        }
    }
}
