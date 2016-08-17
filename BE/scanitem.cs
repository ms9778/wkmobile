namespace BE
{
    public class ScanItem
    {
        public const int SCAN_INVALID = 2;
        public const int SCAN_VALID = 1;
        public const int NOSCAN = 0;

        public ScanItem()
        {
            ShowDifference = false;
        }

        public string BarCode { get; set; }
        public string Journal { get; set; }
        public int Count { get; set; }
        public string Par1 { get; set; }
        public string Par2 { get; set; }
        public string Target { get; set; }
        public string Location { get; set; }
        public string Placement { get; set; }
        public string ItemError { get; set; }
        public double Difference { get; set; }
        public string LineNo { get; set; }
        public bool ShowDifference { get; set; }
    }
}