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

    }
}
