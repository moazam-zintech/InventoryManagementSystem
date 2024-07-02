using InventoryManagementSystem.Model.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options): base(options) { }
        public DbSet<Customer> customers { get; set; }
        public DbSet<inventory> inventories { get; set; }
    }
}