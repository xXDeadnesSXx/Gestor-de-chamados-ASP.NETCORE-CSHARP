using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleChamadosRedeSuporte.Models;

namespace ControleChamadosRedeSuporte.Services
{
    public class GraduacaoService
    {
        private readonly CCRSContext _context;

        public GraduacaoService(CCRSContext context)
        {
            _context = context;
        }

        public List<Graduacao> FindAll()
        {
            return _context.Graduacao.ToList();
        }
    }
}
