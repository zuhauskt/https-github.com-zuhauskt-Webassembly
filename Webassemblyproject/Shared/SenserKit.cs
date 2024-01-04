using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webassemblyproject.Shared
{
    internal class SenserKit
    {
        public int KitId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public DateTime InstallationDate { get; set; }
        public string Status { get; set; }
        public string CalibrationDetails { get; set; }
    }
}
