using Vidly2.Models;

namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly2.Models.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly2.Models.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.Customers.AddOrUpdate(
            //  p => p.,
            //  new Person { FullName = "Andrew Peters" },
            //  new Person { FullName = "Brice Lambson" },
            //  new Person { FullName = "Rowan Miller" }
            //);

            context.Customers.AddOrUpdate(p => p.Name,
                new Customer { Name = "Shefali Lachhar", Id = 1 },
                new Customer { Name = "Ranjeet Kumar", Id = 2 });

        }
    }
}
