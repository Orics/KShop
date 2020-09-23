using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAccess
{
    class DbInitializer: CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            context.Productions.AddRange(
                new Production[] {
                    new Production() { ProductionName = "Apple"},
                    new Production() { ProductionName = "Samsung"},
                    new Production() { ProductionName = "LG"},
                    new Production() { ProductionName = "Oppo"},
                }
            );

            context.SaveChanges();

            //context.Products.Add(
            //    new Phone()
            //    {
            //        ProductName = "Iphone 12",
            //        Quantity = 12,
            //        Color = "White, Gold",
            //        ReleaseDate = new DateTime(2019, 8, 12),
            //        Price = 18900000,
            //        BasePrice = 20000000
            //    }
            //);
            //context.Products.Add(
            //    new Phone()
            //    {
            //        ProductName = "Galaxy A7",
            //        Quantity = 1,
            //        Color = "White, Gold",
            //        ReleaseDate = new DateTime(2020, 8, 12),
            //        Price = 18900000,
            //        BasePrice = 20000000
            //    }
            //);
            //context.Products.Add(
            //    new Phone()
            //    {
            //        ProductName = "Galaxy Note",
            //        Quantity = 1,
            //        Color = "White, Gold",
            //        ReleaseDate = new DateTime(2020, 8, 12),
            //        Price = 18900000,
            //        BasePrice = 20000000
            //    }
            //);
        }
    }
}
