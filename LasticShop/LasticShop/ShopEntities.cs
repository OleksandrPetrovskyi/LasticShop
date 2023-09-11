using LasticShop.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace LasticShop
{
    public class ShopEntities : DbContext
    {
        public ShopEntities(DbContextOptions<ShopEntities> options) : base(options) 
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
