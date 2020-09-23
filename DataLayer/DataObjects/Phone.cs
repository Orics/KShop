using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class Phone : Product
    {
        public ICollection<PhoneModel> Models { get; set; }

    }
}