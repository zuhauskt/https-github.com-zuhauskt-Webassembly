using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webassemblyproject.Shared
{
    internal class Liquid
    {
        public int LiquidId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string StorageConditions { get; set; }
    }
}
