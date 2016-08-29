using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class SharedConnector : DbConnecter
    {

        

        public List<string> selectItems()
        {
            var list2 = Db.Inventories.ToList();
            List<string> itemlist = new List<string>();

            foreach (var x in list2)
            {
                var item = x.Item;
                if (item != null)
                {
                    itemlist.Add(item);
                }
                
            }

            return itemlist;
        }
    }
}
