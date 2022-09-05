using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1petshop2.Models;

namespace WebApplication1petshop2.Controllers
{
    public class ServiçosController : Controller
    {
        private readonly WebApplication1petshop2Context _context;

        public ServiçosController(WebApplication1petshop2Context context)
        {
            _context = context;
        }

        // GET: Serviços1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Serviços.ToListAsync());
        }

        // GET: Serviços1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviços = await _context.Serviços
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviços == null)
            {
                return NotFound();
            }

            return View(serviços);
        }

        // GET: Serviços1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Serviços1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Serviços serviços)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviços);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviços);
        }

        // GET: Serviços1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviços = await _context.Serviços.FindAsync(id);
            if (serviços == null)
            {
                return NotFound();
            }
            return View(serviços);
        }

        // POST: Serviços1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Serviços serviços)
        {
            if (id != serviços.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviços);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiçosExists(serviços.Id))
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
            return View(serviços);
        }

        // GET: Serviços1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviços = await _context.Serviços
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviços == null)
            {
                return NotFound();
            }

            return View(serviços);
        }

        // POST: Serviços1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviços = await _context.Serviços.FindAsync(id);
            _context.Serviços.Remove(serviços);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiçosExists(int id)
        {
            return _context.Serviços.Any(e => e.Id == id);
        }
    }
}
