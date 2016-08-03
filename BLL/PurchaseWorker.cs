using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PurchaseWorker
    {

        public static int MakePurchase(ScanItem item)
        {
            BarcodeSplitter.extractParameters(item);
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
