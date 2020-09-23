﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class InventoryReceivingItem
    {
        public int InventoryReceivingItemId { get; set; }
        public Product Product { get; set; }
        public int? CostPerUnit { get; set; }
        public int? Quantity { get; set; }
    }
}