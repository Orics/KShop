using System.Collections.Generic;

namespace DataLayer.DataObjects
{
    public class Production
    {
        public int Id { get; set; }
        public string ProductionName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}