using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleChamadosRedeSuporte.Models
{
    public class Graduacao
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        //Associação de 1 para muitos com Funcionario, intanciada
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Graduacao()
        {
        }
        //Construtor sem coleções
        public Graduacao(int id, string grad)
        {
            Id = id;
            Grad = grad;
        }
    }
}
