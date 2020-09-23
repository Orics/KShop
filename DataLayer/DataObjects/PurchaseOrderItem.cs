namespace DataLayer.DataObjects
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
    }
}