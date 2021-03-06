﻿using ControleChamadosRedeSuporte.Enums;
using System.Collections.Generic;

namespace ControleChamadosRedeSuporte.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public int Rg { get; set; }
        //Associação 1 para 1
        public Graduacao Graduacao { get; set; }
        public int GraduacaoId { get; set; }//mater  a integridade relacional
        public string Name { get; set; }
        //Associação 1 para 1
        public Unidade Unidade { get; set; }
        public int UnidadeId { get; set; }//mater  a integridade relacional
        public FuncionTipo Tipo { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, int rg, Graduacao graduacao, string name, Unidade unidade, FuncionTipo tipo)
        {
            Id = id;
            Rg = rg;
            Graduacao = graduacao;
            Name = name;
            Unidade = unidade;
            Tipo = tipo;
        }
    }
}
