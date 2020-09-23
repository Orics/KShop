using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessLayer.Models
{
    public class PhoneModelRequest : BaseModel
    {

        #region properties
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public int? ProductionId { get; set; }

        public string Color { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? Quantity { get; set; }

        public Dictionary<string, string> Network { get; set; }

        public Dictionary<string, string> Body { get; set; }

        public Dictionary<string, string> Display { get; set; }

        public Dictionary<string, string> Platfrom { get; set; }

        public Dictionary<string, string> Memory { get; set; }

        public Dictionary<string, string> MainCamera { get; set; }

        public Dictionary<string, string> SelfieCamera { get; set; }

        public Dictionary<string, string> Sound { get; set; }

        public Dictionary<string, string> Communications { get; set; }

        public Dictionary<string, string> Features { get; set; }

        public Dictionary<string, string> Battery { get; set; }
        #endregion



        public Phone ToPhone() {

            return new Phone()
            {
                ProductName = this.ProductName,
                Production = (new DataLayer.DataAccess.Context().Productions.Find(this.ProductionId)),
                Quantity = 0,
            };
        }


        public override bool IsValidate()
        {
            return true;
        }
    }
}