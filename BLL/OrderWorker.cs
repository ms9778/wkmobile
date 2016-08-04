using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class OrderWorker
    {
        public static int MakeOrder(ScanItem item)
        {
            BarcodeSplitter.ExtractParameters(item);
            var oc = new OrderConnector();
            return oc.ScanOrder(item);
        }

        public static List<Order> GetCurrentOrders(string p, int t)
        {
            var oc = new OrderConnector();
            return oc.GetOrdersWithStatus(p, t);
        }
    }
}