using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class OrderLineWorker
    {
        public int DeleteOrderLine(int id)
        {
            var olc = new OrderLineConnector();
            return olc.DeleteOrderLine(id);
        }

        public void UpdateOrderLine(int originalRecordId,int originalOrdered, int ordered)
        {
            var olc = new OrderLineConnector();
            olc.UpdateOrderLine(originalRecordId,originalOrdered, ordered);
        }
    }
}
