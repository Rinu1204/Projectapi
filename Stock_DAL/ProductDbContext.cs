using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stock_DAL.Model;

namespace Stock_DAL
{
    public class ProductDbContext:IdentityDbContext<IdentityUser>
    {
       

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProductDB;Trusted_Connection=True;");
                base.OnConfiguring(optionsBuilder);
            }

            public DbSet<Product> ?product{ get; set; }

            public DbSet<Cart> ?cart { get; set; }
               public DbSet<Order>? Order { get; set; }

        public DbSet<Product_Details>? Product_Details { get; set; }



    }
}