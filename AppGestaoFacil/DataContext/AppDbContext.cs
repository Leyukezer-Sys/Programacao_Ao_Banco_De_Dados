using AppGestaoFacil.Model;
using Microsoft.EntityFrameworkCore;

namespace AppGestaoFacil.DataContext
{
    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Servidor> Servidores { get; set; }
    }
}
