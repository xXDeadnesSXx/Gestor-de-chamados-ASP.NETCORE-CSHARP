using System.Collections.Generic;

namespace ControleChamadosRedeSuporte.Models
{
    public class Unidade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Associação 1 para muitos, intanciada
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Unidade() { }

        public Unidade(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
