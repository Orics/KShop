
using BussinessLayer.Models;
using DataLayer.DataObjects;
using System.Collections.Generic;
using System.Linq;


namespace BussinessLayer.Services
{
    public class PhoneServices
    {
        public IEnumerable<PhoneModelResponse> GetAllPhones() 
        {
            using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context()) {
                List<PhoneModelResponse> list = new List<PhoneModelResponse>(); 
                foreach (Phone phone in context.Products.OfType<Phone>().ToArray()) {
                    list.Add(
                        new PhoneModelResponse(phone)
                    ); 
                }
                return list;
            }
        }

        public PhoneModelResponse GetPhone(int id) {
            using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
            {
                var phone = context.Products.OfType<Phone>().First(p=> p.Id == id);
                if (phone != null)
                    return new PhoneModelResponse(phone);
                else
                    return null;
            }
        }

        public int CreatePhone(PhoneModelRequest data)
        {
            if(data != null && data.IsValidate())
            {
                Phone phone = data.ToPhone();
                using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
                {
                    context.Products.Add(phone);

                    context.SaveChanges();

                    return phone.Id;
                }
            }
            return 0;
        }

        public bool UpdatePhone(int id, PhoneModelRequest data) {

            if (data != null && data.IsValidate())
            {
                using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context())
                {
                    Phone phone = context.Products.OfType<Phone>().First(p=>p.Id == id);

                    if(phone != null)
                    {
                        //update data
                    }

                    context.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        public bool DeletePhone(int id)
        {

            return true;
        }
    }
}
