using System.Collections.Generic;
using BE;

namespace Winkompass_Mobil.Models
{
    public class ScannedItemsModel
    {
        public ScannedItemsModel()
        {
            Items = new List<InventoryCount>();
        }

        public List<InventoryCount> Items { get; set; }
    }
}