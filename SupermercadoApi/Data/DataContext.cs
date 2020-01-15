using Microsoft.EntityFrameworkCore;
using SupermercadoApi.Data.Entities;

namespace SupermercadoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
