using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderLineConnector : DbConnecter
    {
        public int DeleteOrderLine(int recordId)
        {
            return Db.Public_OrderLine_Delete(recordId, null, null, null);
        }

        public void UpdateOrderLine(int originalRecordId,int originalOrdered,  int ordered)
        {
            Db.Public_OrderLine_Update(null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, ordered, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, originalOrdered, null, null, null, null, null, null, originalRecordId, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null);
            //Db.Public_OrderLine_Update(original_RecordId: originalRecordId, original_Ordered: originalOrdered, ordered: ordered);
        }
    }
}
