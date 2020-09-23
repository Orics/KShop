using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Models.RequestModels
{
    class CustomerModelResquest : BaseModel
    {
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

        public Customer ToCustomer() {
            return new Customer()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                ToKen = null,
                PurchaseOrders = null
            };
        }
    }
}
