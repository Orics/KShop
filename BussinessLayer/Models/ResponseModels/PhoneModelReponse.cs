using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessLayer.Models
{
    public class PhoneModelResponse : BaseModel
    {

        #region contructors
        public PhoneModelResponse(Phone entity) {
            if(entity != null)
            {
                Id = entity.Id;
                ProductName = entity.ProductName;
            }  
        }
        #endregion

        #region properties
        public int Id { get; set; }
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public ProductionModelResponse Production { get; set; }

        public string Color { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? Quantity { get; set; }

        public string Network { get; set; }

        public string Body { get; set; }

        public string Display { get; set; }

        public string Platfrom { get; set; }

        public string Memory { get; set; }

        public string MainCamera { get; set; }

        public string SelfieCamera { get; set; }

        public string Sound { get; set; }

        public string Communications { get; set; }

        public string Features { get; set; }

        public string Battery { get; set; }

    #endregion

        public override bool IsValidate()
        {
            throw new NotImplementedException();
        }
    }
}