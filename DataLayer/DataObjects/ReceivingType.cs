using System;

namespace DataLayer.DataObjects
{
    public class ReceivingType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string OtherRequirement { get; set; }
    }

    public class ShippingType : ReceivingType
    {
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }

    public class ShoppingType : ReceivingType
    {
        public DateTime? ExpectedDate { get; set; }

    }

}