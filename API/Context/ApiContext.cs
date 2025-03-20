using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = tcp:10.20.103.37, 1433; Database = ApiProjectDB; User ID = SA; Password = Softito1882; Trusted_Connection = False; Encrypt = False; ");
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
