using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webassemblyproject.Shared
{
    internal class BillDetailes
    {
        public int DetailId { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}
