using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class PurchaseWorker
    {
        public static int MakePurchase(ScanItem item)
        {
            BarcodeSplitter.ExtractParameters(item);
            var pc = new PurchaseConnector();
            return pc.MakePurchase(item);
        }

        public static List<PurchaseDetails> GetPurchasesWithStatus(string p)
        {
            var pc = new PurchaseConnector();
            return pc.GetPurchasesWithStatus(p);
        }
    }
}