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
    }
}
