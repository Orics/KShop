using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataObjects
{
    public class Invoice
    {
        public int Id { get; set; }
        public Staff Staff { get; set; }
        public DateTime Time { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Payment Payment { get; set; }
        public InvoiceStatus Status { get; set; }
    }
}
