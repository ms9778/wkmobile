using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderWorker
    {
        public static int MakeOrder(ScanItem item)
        {
            BarcodeSplitter.extractParameters(item);
            var oc = new OrderConnector();
            return oc.ScanOrder(item);
        }

        public static List<Order> GetCurrentOrders(string p,int t)
        {
            var oc = new OrderConnector();
            return oc.GetOrdersWithStatus(p,t);
        }
    }
}
