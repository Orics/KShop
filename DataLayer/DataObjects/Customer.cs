using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IdentifyToKen ToKen { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }

    }


    public class IdentifyToKen
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime? ExpiredTime { get; set; }
    }
}