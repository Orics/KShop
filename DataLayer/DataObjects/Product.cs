using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Production Production { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Color { get; set; }
        public int? BasePrice { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }

    }
}