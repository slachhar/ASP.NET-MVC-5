using System.Data.Entity;

namespace Vidly2.Models
{
    public class PlutoContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public PlutoContext()
            : base("name=DefaultConnection")
        {

        }

    }
}