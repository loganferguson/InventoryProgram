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
        static int partCount = 1;
        static int productCount = 1;

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
                inhousePart.PartID = partCount;
                inhousePart.PartName = a.tbPartName.Text;
                inhousePart.Price = partPrice;
                inhousePart.Min = partMin;
                inhousePart.Max = partMax;
                inhousePart.InStock = partInventory;
                int machine = int.Parse(a.tbMachineID.Text);
                inhousePart.MachineID = machine;
                Inventory.AllParts.Add(inhousePart);

                mainform.InitializePartDataGridView();
                a.Close();
                partCount += 1;
            }
            else if (a.rdOutsourced.Checked)
            {
                Outsourced outPart = new Outsourced();
                
                outPart.PartID = partCount;
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
                partCount += 1;
            }
        }

        //This addPart overload is used when user modifies part source value (Outsourced/Inhouse):
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
                    inhousePart.PartID = int.Parse(m.tbModPartID.Text);
                    inhousePart.PartName = m.tbModPartName.Text;
                    inhousePart.Price = partPrice;
                    inhousePart.Min = partMin;
                    inhousePart.Max = partMax;
                    inhousePart.InStock = partInventory;
                    int machine = int.Parse(m.tbModMachineID.Text);
                    inhousePart.MachineID = machine;

                Inventory.AllParts.Add(inhousePart);
                mainform.InitializePartDataGridView();
                m.Close();
            }
            else if (m.rbModOutSourced.Checked)
            {
                Outsourced outPart = new Outsourced();
                    outPart.PartID = int.Parse(m.tbModPartID.Text);
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
                outPart.Price = decimal.Parse(m.tbModPartPrice.Text);
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
            m.dgvParts.ClearSelection();
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

        //Delete Part overloaded methods for Inhouse and Outsourced respectively:
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
            prod.ProductID = productCount;
            prod.ProductName = p.tbProductName.Text;
            prod.InStock = int.Parse(p.tbProductInventory.Text.ToString());
            prod.Price = decimal.Parse(p.tbProductPrice.Text.ToString());
            prod.Min = int.Parse(p.tbProductMin.Text.ToString());
            prod.Max = int.Parse(p.tbProductMax.Text.ToString());

            Products.Add(prod);
            productCount += 1;

        }

        public static void UpdateProduct(ModifyProductForm m, mainForm main)
        {
            var prod = Inventory.Products.Where(x => x.ProductID == int.Parse(m.tbModProductID.Text)).First();
            prod.ProductName = m.tbModProductName.Text;
            prod.InStock = int.Parse(m.tbModProductInventory.Text);
            prod.Price = decimal.Parse(m.tbModProductPrice.Text);
            prod.Min = int.Parse(m.tbModProductMin.Text);
            prod.Max = int.Parse(m.tbModProductMax.Text);
            m.Close();
            main.InitializeProductDataGridView();
        }

        public void RemoveProduct(mainForm main)
        {
            foreach(DataGridViewRow row in main.dgvProducts.SelectedRows)
            {
                var p = Products.Where(x => x.ProductID == int.Parse(row.Cells[0].Value.ToString())).First();
                if(p.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("This product cannot be deleted until the associated parts are removed.");
                    return;
                }
                main.dgvProducts.Rows.Remove(row);
            }
            main.InitializeProductDataGridView();
        }

        public void LookupProduct(mainForm main)
        {
            main.dgvProducts.ClearSelection();
            string searchValue = main.tbProductSearch.Text;

            if (String.IsNullOrEmpty(searchValue))
            {
                return;
            }

            foreach (DataGridViewRow row in mainform.dgvProducts.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Contains(searchValue))
                {
                    row.Selected = true;
                }
            }
        }

        //Unused Methods:

        public void addProduct(Product p)
        {
            Products.Add(p);
        }
        public bool removeProduct(int id)
        {
            var p = Products.Where(x => x.ProductID == id).First();
            Products.Remove(p);
            return true;
        }

        public Product lookupProduct(int id)
        {
            string search = mainform.tbProductSearch.Text;
            foreach(DataGridViewRow row in mainform.dgvProducts.Rows)
            {
                if(row.Cells[1].Value.ToString() == search)
                {
                    row.Selected = true;
                    
                }
            }
            Product p = Products.Where(x => x.ProductID == id).First();
            return p;
        }

        public void updateProduct(int id, Product p)
        {
            var prod = Products.Where(x => x.ProductID == id).First();

            prod.ProductName = p.ProductName;
            prod.Price = p.Price;
            prod.InStock = p.InStock;
            prod.Min = p.Min;
            prod.Max = p.Max;
        }
        public void addPart(Part p)
        {
            AllParts.Add(p);
        }

        public bool deletePart(Part p)
        {
            AllParts.Remove(p);
            return true;
        }
        public Part lookupPart(int id)
        {
            string search = mainform.tbPartSearch.Text;
            foreach (DataGridViewRow row in mainform.dgvParts.Rows)
            {
                if (row.Cells[1].Value.ToString() == search)
                {
                    row.Selected = true;

                }
            }
            var p = AllParts.Where(x => x.PartID == id).First();
            return p;
        }
        public void updatePart(int id, Part p)
        {
            var part = AllParts.Where(x => x.PartID == id).First();

            part.PartName = p.PartName;
            part.Price = p.Price;
            part.InStock = p.InStock;
            part.Min = p.Min;
            part.Max = p.Max;
        }


    }
}
