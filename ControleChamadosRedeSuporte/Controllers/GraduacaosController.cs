using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleChamadosRedeSuporte.Data;
using ControleChamadosRedeSuporte.Models;

namespace ControleChamadosRedeSuporte.Controllers
{
    public class GraduacaosController : Controller
    {
        private readonly CCRSContext _context;

        public GraduacaosController(CCRSContext context)
        {
            _context = context;
        }

        // GET: Graduacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Graduacao.ToListAsync());
        }

        // GET: Graduacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduacao = await _context.Graduacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graduacao == null)
            {
                return NotFound();
            }

            return View(graduacao);
        }

        // GET: Graduacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Graduacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Grad")] Graduacao graduacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(graduacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(graduacao);
        }

        // GET: Graduacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduacao = await _context.Graduacao.FindAsync(id);
            if (graduacao == null)
            {
                return NotFound();
            }
            return View(graduacao);
        }

        // POST: Graduacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Grad")] Graduacao graduacao)
        {
            if (id != graduacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(graduacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraduacaoExists(graduacao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(graduacao);
        }

        // GET: Graduacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduacao = await _context.Graduacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graduacao == null)
            {
                return NotFound();
            }

            return View(graduacao);
        }

        // POST: Graduacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var graduacao = await _context.Graduacao.FindAsync(id);
            _context.Graduacao.Remove(graduacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraduacaoExists(int id)
        {
            return _context.Graduacao.Any(e => e.Id == id);
        }
    }
}
