using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace BLL
{
    public class PurchaseLineWorker
    {
        public int DeletePurchaseLine(int orderLineId)
        {
            var plc = new PurchaseLineConnector();
            return plc.DeletePurchaseLine(orderLineId.ToString());
        }

        public void UpdatePurchaseLine(int originalRecordId, int originalOrdered, int ordered)
        {
            var plc = new PurchaseLineConnector();
            plc.UpdatePurchaseLine(originalRecordId, originalOrdered, ordered);
        }
    }
}
