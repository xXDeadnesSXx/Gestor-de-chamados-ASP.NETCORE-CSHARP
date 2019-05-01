using ControleChamadosRedeSuporte.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleChamadosRedeSuporte.Data
{
    public class CCRSContext : DbContext
    {
        public CCRSContext (DbContextOptions<CCRSContext> options) : base(options)
        {
        }
        public DbSet<Chamado> Chamado { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Graduacao> Graduacao { get; set; }
        public DbSet<TipoProblema> TipoProblema { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
    }
}
