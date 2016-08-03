using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;

namespace Winkompass_Mobil.Models
{
    public class ScanItemModel
    {
        public const string CONTINUE_SCANNING = "OK - Scan videre";
        public const string SCAN_AND_STOP = "OK - Afslut";

        public ScanItem item { get; set; }
        public float scanned { get; set; }
        public string Error { get; set; }
        public string target { get; set; }
        public string message { get; set; }
        

        public ScanItemModel()
        {
            
            scanned = 0;
         
        }
    }
}
