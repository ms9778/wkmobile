﻿using System;
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
    }
}
