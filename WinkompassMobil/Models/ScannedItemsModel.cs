using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winkompass_Mobil.Models
{
    public class ScannedItemsModel
    {
        public List<InventoryCount> items{get;set;}
        public ScannedItemsModel()
        {
            items=new List<InventoryCount>();
        }
    }
}