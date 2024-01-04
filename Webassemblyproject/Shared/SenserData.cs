using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webassemblyproject.Shared
{
    internal class SenserData
    {
        public int DataId { get; set; }
        public int SensorId { get; set; }
        public DateTime Timestamp { get; set; }
        public double ReadingValue { get; set; }
        public string Location { get; set; }
        public string DataType { get; set; }
    }
}
