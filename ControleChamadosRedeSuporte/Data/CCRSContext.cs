using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleChamadosRedeSuporte.Models;

namespace ControleChamadosRedeSuporte.Models
{
    public class CCRSContext : DbContext
    {
        public CCRSContext (DbContextOptions<CCRSContext> options)
            : base(options)
        {
        }

        public DbSet<Chamado> Chamado { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Graduacao> Graduacao { get; set; }
        public DbSet<TipoProblema> TipoProblema { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
    }
}
