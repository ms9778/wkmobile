using BE;

namespace Winkompass_Mobil.Models
{
    public class ScanItemModel
    {
        public const string ContinueScanning = "OK - Scan videre";
        public const string ScanAndStop = "OK - Afslut";


        public ScanItemModel()
        {
            Scanned = 0;
        }

        public ScanItem Item { get; set; }
        public float Scanned { get; set; }
        public string Error { get; set; }
        public string Target { get; set; }
        public string Message { get; set; }
        public string storageId { get; set; }

    }
}