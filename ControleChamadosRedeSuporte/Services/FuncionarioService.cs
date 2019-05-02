using ControleChamadosRedeSuporte.Data;
using ControleChamadosRedeSuporte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//Biblioteca que possibilita o JOIN
using ControleChamadosRedeSuporte.Services.Exceptions;

namespace ControleChamadosRedeSuporte.Services
{
    public class FuncionarioService
    {//Serviço registrado no Startup.cs
        private readonly CCRSContext _context;

        public FuncionarioService(CCRSContext context)
        {
            _context = context;
        }

        public List<Funcionario> FindAll()
        {//Operação sincrona, toda a operação tem que terminar antes de continuar
            return _context.Funcionario.ToList();
        }

        public void Insert(Funcionario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Funcionario FindById(int id)
        {//Include(obj => obj.Graduacao) faz um Join entre as tabelas
            return _context.Funcionario.Include(obj => obj.Graduacao).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Funcionario.Find(id);
            _context.Funcionario.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Funcionario funcionario)
        {
            if (!_context.Funcionario.Any(id => id.Id == funcionario.Id))//Verifica se NÃO existe funcionario com o Id
            {
                throw new NotFoundExcepion("Funcionário não encontrado");//Excepion personalizado em Service.Exceptions
            }
            try
            {//Se o funcionario existir o try tenta atualizar
                _context.Update(funcionario);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {//Caso haja conflito de concorrência usa a exception personalizada de concorência
                throw new DbConcurrencyExcepion(e.Message);
            }
        }
    }
}
