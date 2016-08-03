using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ScanItem
    {
        public const int SCAN_INVALID = 2;
        public const int SCAN_VALID = 1;
        public const int NOSCAN = 0;

        public string barCode { get; set; }
        public string Journal { get; set; }
        public int count { get; set; }
        public string par1 { get; set; }
        public string par2 { get; set; }
        public string target { get; set; }
        public string location { get; set; }
        public string ItemError { get; set; }
        public double difference { get; set; }
        public string LineNo { get; set; }
        public Boolean showDifference { get; set; }
        public ScanItem()
        {
            showDifference = false;
        }
    }
}
