using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.DataObjects
{
    public class Staff
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleLevel Level { get; set; }
    }
}