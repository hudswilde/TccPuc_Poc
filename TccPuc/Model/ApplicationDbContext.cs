using Microsoft.EntityFrameworkCore;
using TccPuc.Model;

namespace TccPuc.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Consultancies> Consultancies { get; set; }
        public DbSet<Standards> Standards { get; set; }
        public DbSet<Perfil> Perfil{ get; set; }
        public DbSet<HistoricoVersao> HistoricoVersao { get; set; }
        
        public DbSet<Usuario> Usuario { get; set; }
    }
}
