using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class Promotion
    {
        public int Id { get; set; }
        public string PromotionName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? DiscountRate { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}