using Microsoft.AspNetCore.Mvc;
using ControleChamadosRedeSuporte.Data;
using ControleChamadosRedeSuporte.Services;
using ControleChamadosRedeSuporte.Models.ViewModel;
using ControleChamadosRedeSuporte.Models;

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
