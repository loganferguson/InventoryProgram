using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram
{
    class Part
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public bool IsOutsourced { get; set; }

    }
}
