using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AT_C__Felipe.Data;
using AT_C__Felipe.Models;

namespace AT_C__Felipe.Controllers
{
    public class jogadorsController : Controller
    {
        private readonly AT_C__FelipeContext _context;

        public jogadorsController(AT_C__FelipeContext context)
        {
            _context = context;
        }

        // GET: jogadors
        public async Task<IActionResult> Index()
        {
              return _context.jogador != null ? 
                          View(await _context.jogador.ToListAsync()) :
                          Problem("Entity set 'AT_C__FelipeContext.jogador'  is null.");
        }

        // GET: jogadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.jogador == null)
            {
                return NotFound();
            }

            var jogador = await _context.jogador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        // GET: jogadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: jogadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,gamertag,level")] jogador jogador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jogador);
        }

        // GET: jogadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.jogador == null)
            {
                return NotFound();
            }

            var jogador = await _context.jogador.FindAsync(id);
            if (jogador == null)
            {
                return NotFound();
            }
            return View(jogador);
        }

        // POST: jogadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,gamertag,level")] jogador jogador)
        {
            if (id != jogador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!jogadorExists(jogador.Id))
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
            return View(jogador);
        }

        // GET: jogadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.jogador == null)
            {
                return NotFound();
            }

            var jogador = await _context.jogador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        // POST: jogadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.jogador == null)
            {
                return Problem("Entity set 'AT_C__FelipeContext.jogador'  is null.");
            }
            var jogador = await _context.jogador.FindAsync(id);
            if (jogador != null)
            {
                _context.jogador.Remove(jogador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool jogadorExists(int id)
        {
          return (_context.jogador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
