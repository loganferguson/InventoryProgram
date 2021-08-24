using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram
{
    public static class Inventory
    {
        public static List<Part> AllParts = new List<Part>();
        static List<Product> Products { get; set; }
    }
}
