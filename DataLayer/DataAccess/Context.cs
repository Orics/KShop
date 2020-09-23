using DataLayer.DataObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataLayer.DataAccess
{
    public class Context : DbContext
    {
        public Context() : base("name=KShop-connectionString")
        {
            var init = new DbInitializer();
            init.InitializeDatabase(this);
            Database.SetInitializer(init);
            Database.CreateIfNotExists();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<ReceivingType> ReceivingTypes { get; set; }
        public DbSet<PurchaseOrderStatus> PurchaseOrderStatuses{ get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<InventoryReceiving> InventoryReceivings { get; set; }
        public DbSet<InventoryReceivingItem> InventoryReceivingItems { get; set; }
        public DbSet<Staff> Accounts { get; set; }
        public DbSet<RoleLevel> RoleLevels { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PhoneModel> PhoneModels { get; set; }
        public DbSet<LaptopModel> LaptopModels { get; set; }

    }


}