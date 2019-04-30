using System.Collections.Generic;

namespace ControleChamadosRedeSuporte.Models.ViewModel
{
    public class UnidadeFormViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Unidade> Unidades { get; set; }
        public ICollection<Graduacao> Graduacaos { get; set; }
    }
}
