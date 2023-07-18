using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order> Users { get; set; }
        public DbSet<Description> Descriptions { get; set; }


        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options){} 
        
    }
}