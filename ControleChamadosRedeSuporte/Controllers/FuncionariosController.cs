using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleChamadosRedeSuporte.Models;
using ControleChamadosRedeSuporte.Models.ViewModel;
using ControleChamadosRedeSuporte.Services;

namespace ControleChamadosRedeSuporte.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        private readonly UnidadeService _unidadeService;

        public FuncionariosController(
            FuncionarioService  funcionarioService, UnidadeService unidadeService)
        {
            _funcionarioService = funcionarioService;
            _unidadeService = unidadeService;
        }

        public IActionResult Index()
        {
            var list = _funcionarioService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var unidades = _unidadeService.FindAll();
            var graduacaos = _unidadeService.FindAllGrad();
            var viewModel = new UnidadeFormViewModel { Unidades = unidades, Graduacaos = graduacaos};

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Funcionario funcionario)
        {
            _funcionarioService.Insert(funcionario);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)//opcional
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _funcionarioService.FindById(id.Value);//.value pq id é opcional
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Delete(int id)
        {
            _funcionarioService.Remove(id);
            return RedirectToAction(nameof(Index));

        }

    }
}
