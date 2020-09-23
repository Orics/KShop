using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class Laptop : Product
    {
        public ICollection<LaptopModel> Models { get; set; }

    }
}