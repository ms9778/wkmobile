using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winkompass_Mobil.Models
{
    public class CreateOrderModel
    {
        public ScanItemModel reg { get; set; }
        public List<OrderListModel> model { get; set; }
    }
}