using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    
    public class Product
    {
        public AddProductForm addProductForm;
     
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public List<Part> AssociatedParts { get; set; }

        public Product(AddProductForm form)
        {
            addProductForm = form;         
            AssociatedParts = new List<Part>();
        }

        // Two overloaded method versions for adding to associated parts list:
        public void AddAssociatedPart(DataGridViewRow row, Product p)
        {
            int partID = int.Parse(row.Cells[0].Value.ToString());
            string partName = row.Cells[1].Value.ToString();
            decimal price = decimal.Parse(row.Cells[2].Value.ToString());
            int inStock = int.Parse(row.Cells[3].Value.ToString());
            
            int min = int.Parse(row.Cells[4].Value.ToString());
            int max = int.Parse(row.Cells[5].Value.ToString());

            if (row.DataBoundItem is Outsourced)
            {
                Outsourced part = new Outsourced();

                part.PartID = partID;
                part.PartName = partName;
                part.InStock = inStock;
                part.Price = price;
                part.Min = min;
                part.Max = max;

                p.AssociatedParts.Add(part);
                addProductForm.InitializeAssociatedGridView();             
            }
            else
            {
                Inhouse part = new Inhouse();

                part.PartID = partID;
                part.PartName = partName;
                part.InStock = inStock;
                part.Price = price;
                part.Min = min;
                part.Max = max;

                p.AssociatedParts.Add(part);
                addProductForm.InitializeAssociatedGridView();
            }

        }

        public void AddAssociatedPart(DataGridViewRow row, Product p, ModifyProductForm form)
        {
            int partID = int.Parse(row.Cells[0].Value.ToString());
            string partName = row.Cells[1].Value.ToString();
            decimal price = decimal.Parse(row.Cells[2].Value.ToString());
            int inStock = int.Parse(row.Cells[3].Value.ToString());

            int min = int.Parse(row.Cells[4].Value.ToString());
            int max = int.Parse(row.Cells[5].Value.ToString());

            if (row.DataBoundItem is Outsourced)
            {
                Outsourced part = new Outsourced();

                part.PartID = partID;
                part.PartName = partName;
                part.InStock = inStock;
                part.Price = price;
                part.Min = min;
                part.Max = max;

                p.AssociatedParts.Add(part);
                addProductForm.InitializeAssociatedGridView();
                form.InitializeDgvAssociatedParts();

            }
            else
            {
                Inhouse part = new Inhouse();

                part.PartID = partID;
                part.PartName = partName;
                part.InStock = inStock;
                part.Price = price;
                part.Min = min;
                part.Max = max;

                p.AssociatedParts.Add(part);
                addProductForm.InitializeAssociatedGridView();
                form.InitializeDgvAssociatedParts();
            }

        }


        // Two overload method versions for removing from associated parts list:
        public void RemoveAssociatedPart(DataGridViewRow row, ModifyProductForm form)
        {
            form.dgvAssociatedParts.Rows.Remove(row);
        }

        public void RemoveAssociatedPart(DataGridViewRow row, AddProductForm form)
        {
            form.dgvAssociatedParts.Rows.Remove(row);
        }

        public void LookupCandidatePart(AddProductForm form)
        {
            form.dgvCandidateParts.ClearSelection();
            string searchValue = form.tbCandidateSearch.Text;

            if (String.IsNullOrEmpty(searchValue))
            {
                return;
            }

            foreach (DataGridViewRow row in form.dgvCandidateParts.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Contains(searchValue))
                {
                    row.Selected = true;
                }
            }
        }


        //Unused Methods:

        public void addAssociatedPart(Part p)
        {
            addProductForm.dgvAssociatedParts.Rows.Add(p.PartID, p.PartName, p.InStock, p.Price, p.Min, p.Max);
        }

        public bool removeAssociatedPart(int index)
        {
            var p = AssociatedParts[index];
            AssociatedParts.Remove(p);
            return true;
        }

        public Part lookupAssociatedPart(int id)
        {
            string search = addProductForm.tbCandidateSearch.Text;
            foreach (DataGridViewRow row in addProductForm.dgvCandidateParts.Rows)
            {
                if (row.Cells[1].Value.ToString() == search)
                {
                    row.Selected = true;

                }
            }
            var p = Inventory.AllParts.Where(x => x.PartID == id).First();
            return p;
        }

    }
}
