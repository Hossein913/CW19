using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.DAL
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions dbContextOptions) :base(dbContextOptions)
        {
            
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasOne(cu => cu.Cart).WithOne(ca => ca.Customer).HasForeignKey<Customer>(cu=>cu.CartId);
        }

    }
}




