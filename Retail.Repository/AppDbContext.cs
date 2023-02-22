using Microsoft.EntityFrameworkCore;
using Retail.Repository.Entity;

namespace Retail.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ProductsEntity> Products { get; set; }

    }
}
