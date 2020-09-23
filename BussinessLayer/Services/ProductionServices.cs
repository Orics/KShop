using BussinessLayer.Models;
using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BussinessLayer.Services
{
    public class ProductionServices
    {
        public List<PhoneModelResponse> GetAllPhonesOfProduction(int id)
        {
            using (DataLayer.DataAccess.Context context = new DataLayer.DataAccess.Context()) {
                List<PhoneModelResponse> list = new List<PhoneModelResponse>();
                var products =  context.Productions.Include(p => p.Products).First(p => p.Id == id).Products;
                if(products != null)
                foreach (Phone phone in products) {
                    list.Add(
                        new PhoneModelResponse(phone)
                    );
                }
                return list;
            }
        }
    }
}
