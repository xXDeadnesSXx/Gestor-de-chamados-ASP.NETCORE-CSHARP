using ControleChamadosRedeSuporte.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleChamadosRedeSuporte.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public Funcionario FuncionarioId { get; set; }//Integridade relacional
        public string Tel { get; set; }
        //Assoc. 1 para 1
        public TipoProblema TipoProblema { get; set; }
        public string DescProblema { get; set; }
        public Status Status { get; set; }//enum

        public Chamado() { }

        public Chamado(int id, Funcionario funcionario, string tel, TipoProblema tipoProblema, string descProblema, Status status)
        {
            Id = id;
            Funcionario = funcionario;
            Tel = tel;
            TipoProblema = tipoProblema;
            DescProblema = descProblema;
            Status = status;
        }
    }
}
