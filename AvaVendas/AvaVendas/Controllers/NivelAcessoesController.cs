using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvaVendas.Data;
using AvaVendas.Models;

namespace AvaVendas.Controllers
{
    public class NivelAcessoesController : Controller
    {
        private readonly AvaVendasContext _context;

        public NivelAcessoesController(AvaVendasContext context)
        {
            _context = context;
        }

        // GET: NivelAcessoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.NivelAcesso.ToListAsync());
        }

        // GET: NivelAcessoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelAcesso = await _context.NivelAcesso
                .FirstOrDefaultAsync(m => m.NivelID == id);
            if (nivelAcesso == null)
            {
                return NotFound();
            }

            return View(nivelAcesso);
        }

        // GET: NivelAcessoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NivelAcessoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NivelID,Acesso")] NivelAcesso nivelAcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivelAcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nivelAcesso);
        }

        // GET: NivelAcessoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelAcesso = await _context.NivelAcesso.FindAsync(id);
            if (nivelAcesso == null)
            {
                return NotFound();
            }
            return View(nivelAcesso);
        }

        // POST: NivelAcessoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NivelID,Acesso")] NivelAcesso nivelAcesso)
        {
            if (id != nivelAcesso.NivelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivelAcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelAcessoExists(nivelAcesso.NivelID))
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
            return View(nivelAcesso);
        }

        // GET: NivelAcessoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelAcesso = await _context.NivelAcesso
                .FirstOrDefaultAsync(m => m.NivelID == id);
            if (nivelAcesso == null)
            {
                return NotFound();
            }

            return View(nivelAcesso);
        }

        // POST: NivelAcessoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivelAcesso = await _context.NivelAcesso.FindAsync(id);
            if (nivelAcesso != null)
            {
                _context.NivelAcesso.Remove(nivelAcesso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelAcessoExists(int id)
        {
            return _context.NivelAcesso.Any(e => e.NivelID == id);
        }
    }
}
