using Microsoft.EntityFrameworkCore;

namespace L01P02_2019CG606.Models
{
    public class restaurateDbContext : DbContext
    {
        public restaurateDbContext(DbContextOptions options) : base(options) { 

        }
        public DbSet<clientes> clientes { get; set; }
        public DbSet<motoristas> motoristas { get; set;}
        public DbSet<pedidos> pedidos { get; set;}
        public DbSet<platos> platos { get; set;}

    }
}
