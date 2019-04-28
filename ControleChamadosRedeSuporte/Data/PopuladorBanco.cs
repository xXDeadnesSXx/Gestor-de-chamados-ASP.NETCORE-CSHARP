using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleChamadosRedeSuporte.Models;

namespace ControleChamadosRedeSuporte.Data
{
    public class PopuladorBanco
    {//injeção de dependência, toda vez que um PopuladorBanco for criado
     //ele vai receber context
        private CCRSContext _context;

        public PopuladorBanco(CCRSContext context)
        {
            _context = context;
        }

        public void Seed()//método para povoar que deve ser adicionado no Startup.cs
        {                          //no método Configure
            if (_context.Graduacao.Any() || _context.TipoProblema.Any())
            {
                //testa se há algum registro na tab Graduacao ou TipoProblema
                //caso haja não faz nada
                return;
            }
            //polulando as tab
            Graduacao g1 = new Graduacao(1,"Cel");
            Graduacao g2 = new Graduacao(2, "Ten Cel");
            Graduacao g3 = new Graduacao(3, "Maj");
            Graduacao g4 = new Graduacao(4, "Cap");
            Graduacao g5 = new Graduacao(5, "1º Ten");
            Graduacao g6 = new Graduacao(6, "2º Ten");
            Graduacao g7 = new Graduacao(7, "Asp");
            Graduacao g8 = new Graduacao(8, "Sub Ten");
            Graduacao g9 = new Graduacao(9, "1º Sgt");
            Graduacao g10 = new Graduacao(10, "2º Sgt");
            Graduacao g11 = new Graduacao(11, "3º Sgt");
            Graduacao g12 = new Graduacao(12, "Cb");
            Graduacao g13 = new Graduacao(13, "Sd");

            TipoProblema t1 = new TipoProblema(1, "Sem conexão com a internet/intranet");
            TipoProblema t2 = new TipoProblema(2, "Computador não imprime");
            TipoProblema t3 = new TipoProblema(3, "Computador com mal funcionamento");
            TipoProblema t4 = new TipoProblema(4, "Falha no sistema");
            TipoProblema t5 = new TipoProblema(5, "Reparo na rede");
            TipoProblema t6 = new TipoProblema(6, "Outro");

            _context.Graduacao.AddRange(g1,g2,g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13);
            _context.TipoProblema.AddRange(t1, t2, t3, t4, t5, t6);

            _context.SaveChanges();




        }
    }
}
