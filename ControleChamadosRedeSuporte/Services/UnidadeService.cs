using System.Collections.Generic;
using System.Linq;
using ControleChamadosRedeSuporte.Models;

namespace ControleChamadosRedeSuporte.Services
{
    public class UnidadeService
    {
        private readonly CCRSContext _context;

        public UnidadeService(CCRSContext context)
        {
            _context = context;
        }

        public List<Unidade> FindAll()
        {
            return _context.Unidade.OrderBy(n => n.Name).ToList();
        }

        public List<Graduacao> FindAllGrad()
        {
            return _context.Graduacao.ToList();
        }
    }
}
