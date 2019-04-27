using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ControleChamadosRedeSuporte.Models
{
    public class CCRSContext : DbContext
    {
        public CCRSContext (DbContextOptions<CCRSContext> options)
            : base(options)
        {
        }

        public DbSet<ControleChamadosRedeSuporte.Models.Unidade> Unidade { get; set; }
    }
}
