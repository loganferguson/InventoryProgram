using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public List<Part> AssociatedParts { get; set; }

    }
}
