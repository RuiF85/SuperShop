using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entitis;

namespace SuperShop.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}
