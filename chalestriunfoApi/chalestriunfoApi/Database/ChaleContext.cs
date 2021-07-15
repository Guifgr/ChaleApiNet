using chalestriunfoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace chalestriunfoApi.Database
{
    public class ChaleContext : DbContext
    {
        public ChaleContext(DbContextOptions<ChaleContext> options) : base(options) { }

        public DbSet<Product> product { get; set; }
    }
}
