using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleChamadosRedeSuporte.Data;
using ControleChamadosRedeSuporte.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ControleChamadosRedeSuporte.Controllers
{
    public class TipoProblemasController : Controller
    {
        private readonly CCRSContext _context;

        public TipoProblemasController(CCRSContext context)
        {
            _context = context;
        }

        // GET: TipoProblemas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoProblema.ToListAsync());
        }

        // GET: TipoProblemas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProblema = await _context.TipoProblema
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoProblema == null)
            {
                return NotFound();
            }

            return View(tipoProblema);
        }

        // GET: TipoProblemas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoProblemas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Problema")] TipoProblema tipoProblema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoProblema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoProblema);
        }

        // GET: TipoProblemas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProblema = await _context.TipoProblema.FindAsync(id);
            if (tipoProblema == null)
            {
                return NotFound();
            }
            return View(tipoProblema);
        }

        // POST: TipoProblemas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Problema")] TipoProblema tipoProblema)
        {
            if (id != tipoProblema.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoProblema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoProblemaExists(tipoProblema.Id))
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
            return View(tipoProblema);
        }

        // GET: TipoProblemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProblema = await _context.TipoProblema
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoProblema == null)
            {
                return NotFound();
            }

            return View(tipoProblema);
        }

        // POST: TipoProblemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoProblema = await _context.TipoProblema.FindAsync(id);
            _context.TipoProblema.Remove(tipoProblema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoProblemaExists(int id)
        {
            return _context.TipoProblema.Any(e => e.Id == id);
        }
    }
}
