using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webassemblyproject.Shared
{
    internal class Inventory
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int QuantityOnHand { get; set; }
        public decimal UnitPrice { get; set; }
        public int SupplierId { get; set; }
        public string StorageLocation { get; set; }
    }
}
