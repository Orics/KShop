﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class InventoryReceiving
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<InventoryReceivingItem> Items { get; set; }
    }
}