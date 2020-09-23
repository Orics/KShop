using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Models.ResponseModels
{
    class CustomerModelResponse : BaseModel
    {
        #region contructors
        public CustomerModelResponse(Customer entity)
        {
            if (entity != null)
            {
                this.Id = entity.Id;
                this.FirstName = entity.FirstName;
                this.LastName = entity.LastName;
                this.Email = entity.Email;
            }
        }
        #endregion

        #region properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        #endregion

        public override bool IsValidate()
        {
            return true;
        }
    }
}
