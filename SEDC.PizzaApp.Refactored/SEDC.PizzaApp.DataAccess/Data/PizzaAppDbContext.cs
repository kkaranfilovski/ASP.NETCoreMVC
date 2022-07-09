using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Data
{
    public class PizzaAppDbContext : DbContext
    {
        public PizzaAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(x => x.PizzaOrders)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            //RelationResolver.AddOrderRelation(modelBuilder);

            modelBuilder.Entity<Pizza>()
                .HasMany(x => x.PizzaOrders)
                .WithOne(x => x.Pizza)
                .HasForeignKey(x => x.PizzaId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            DataSeed.InsertDataInDb(modelBuilder);
        }

    }
}
