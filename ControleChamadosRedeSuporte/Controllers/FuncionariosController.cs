using Microsoft.AspNetCore.Mvc;
using ControleChamadosRedeSuporte.Data;
using ControleChamadosRedeSuporte.Services;
using ControleChamadosRedeSuporte.Models.ViewModel;
using ControleChamadosRedeSuporte.Models;
using System.Collections.Generic;
using ControleChamadosRedeSuporte.Services.Exceptions;

namespace ControleChamadosRedeSuporte.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        private readonly UnidadeService _unidadeService;

        public FuncionariosController(
            FuncionarioService funcionarioService, UnidadeService unidadeService)
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
            var viewModel = new UnidadeFormViewModel { Unidades = unidades, Graduacaos = graduacaos };

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

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _funcionarioService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _funcionarioService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            List<Graduacao> graduacaos = _unidadeService.FindAllGrad();
            List<Unidade> unidades = _unidadeService.FindAll();
            UnidadeFormViewModel viewModel = new UnidadeFormViewModel
            {
                Funcionario = obj,
                Graduacaos = graduacaos,
                Unidades = unidades
            };
            return View(viewModel);
         }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Funcionario funcionario)
        {
            if(id != funcionario.Id)
            {
                return BadRequest();
            }

            try
            {
                _funcionarioService.Update(funcionario);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundExcepion)
            {
                return NotFound();
            }
            catch (DbConcurrencyExcepion)
            {
                return BadRequest();
            }
        }

    }
}
