using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataObjects
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime? Time { get; set; }
        public Customer Customer { get; set; }
        public ReceivingType ReceivingType { get; set; }
        public ICollection<PurchaseOrderItem> Items { get; set; }
        public PurchaseOrderStatus Status { get; set; }

    }
}
