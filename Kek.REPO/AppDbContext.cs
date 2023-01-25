using kek.DATA.Entities;
using kek.DATA.Organize;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kek.REPO
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new UserTypeMap(builder.Entity<UserType>());
            new BuyMap(builder.Entity<Buy>());
            new SellMap(builder.Entity<Sell>());
            new ProductMap(builder.Entity<Product>());
            new CategoryMap(builder.Entity<Category>());
           
        }
    }
}