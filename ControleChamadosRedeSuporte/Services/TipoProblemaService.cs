using ControleChamadosRedeSuporte.Data;
using ControleChamadosRedeSuporte.Models;
using System.Collections.Generic;
using System.Linq;

namespace ControleChamadosRedeSuporte.Services
{
    public class TipoProblemaService
    {
        private readonly CCRSContext _context;

        public TipoProblemaService(CCRSContext context)
        {
            _context = context;
        }

        public List<TipoProblema> FindAll()
        {
            return _context.TipoProblema.OrderBy(n => n.Problema).ToList();
        }
    }
}
