using CustomersOrders.Models;

namespace CustomersOrders.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomersOrders.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CustomersOrders.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Customers.AddOrUpdate(p => p.CustomerId,
                                        new Customer { FName = "John", LName = "Doe", Age = 34},
                                        new Customer { FName = "Maria", LName = "Hernandez", Age = 20, Freqshopcard = true},
                                        new Customer { FName = "Hello", LName = "World", Age = 1}
                                        );

            context.Orders.AddOrUpdate(r => r.OrderId,
                            new Order { Name = "Maria Doe", Amount = 22.22, CustomerId = 1 },
                            new Order { Name = "John Doe", Amount = 12.34, CustomerId = 1 },
                            new Order { Name = "Hello World", Amount = 12.34, CustomerId = 3 }
                            );
        }
    }
}
