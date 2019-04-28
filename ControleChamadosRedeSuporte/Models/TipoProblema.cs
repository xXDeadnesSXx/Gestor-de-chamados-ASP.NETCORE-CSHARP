using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleChamadosRedeSuporte.Models
{
    public class TipoProblema
    {
        public int Id { get; set; }
        public string Problema { get; set; }
        //Assoc. 1 para *
        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();

        public TipoProblema() { }

        public TipoProblema(int id, string problema)
        {
            Id = id;
            Problema = problema;
        }
    }

}
