using Microsoft.EntityFrameworkCore;

namespace LojaDeRoupaAPI.Models
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}
