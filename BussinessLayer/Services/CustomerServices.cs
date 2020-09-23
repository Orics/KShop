using BussinessLayer.Models.RequestModels;
using BussinessLayer.Models.ResponseModels;
using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services
{
    class CustomerServices
    {
        public IEnumerable<CustomerModelResponse> GetAllCustomers()
        {
            using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
            {
                List<CustomerModelResponse> list = new List<CustomerModelResponse>();
                foreach (Customer customer in context.Customers.ToArray())
                {
                    list.Add(
                        new CustomerModelResponse(customer)
                    );
                }
                return list;
            }
        }

        public CustomerModelResponse GetCustomer(int id)
        {
            using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
            {
                Customer customer = context.Customers.Find(id);
                return new CustomerModelResponse(customer);
            }
        }

        public int CreateCustomer(CustomerModelResquest data)
        {
            if (data != null && data.IsValidate())
            {
                Customer customer = data.ToCustomer();
                using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
                {
                    context.Customers.Add(customer);

                    context.SaveChanges();

                    return customer.Id;
                }
            }
            return 0;
        }

        public bool UpdateCustomer(int id, CustomerModelResquest data)
        {
            if (data != null && data.IsValidate())
            {
                using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
                {
                    Customer customer = context.Customers.First(c=> c.Id == id);
                    if(customer != null)
                    {
                        customer.FirstName = data.FirstName;
                        customer.LastName = data.LastName;
                        customer.Email = data.Email;
                    }
                    context.SaveChanges();       
                    return true;
                }
            }
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
            {
                Customer customer = context.Customers.First(c => c.Id == id);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
