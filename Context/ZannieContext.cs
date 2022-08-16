using Microsoft.EntityFrameworkCore;
using Cakes_N_Treats_By_Zannie.Entities;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Configurations;
using System.Reflection;

namespace Cakes_N_Treats_By_Zannie.Context
{
    public class ZannieContext: DbContext
    {
         public ZannieContext(DbContextOptions<ZannieContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            
           modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Treat> Treats {get;set;}
        public DbSet<Category> Categories{get;set;}
        public DbSet<User> Customers {get;set;}
        public DbSet<TreatOrders> TreatOrders{get;set;}
        public DbSet<Order> Orders{get;set;}
         public DbSet<Comment> Comments{get;set;}
           public DbSet<DispatchRider> DispatchRiders{get;set;}
              public DbSet<Delivery> Deliveries{get;set;}
    }
}