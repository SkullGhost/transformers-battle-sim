using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using transformers_battle_sim.Data;
using transformers_battle_sim.Models.Transformer.Impl;

namespace transformers_battle_sim.Controllers
{
    public class TransformersController : Controller
    {
        private readonly transformers_battle_simContext _context;

        public TransformersController(transformers_battle_simContext context)
        {
            _context = context;
        }

        // GET: Transformers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transformer.ToListAsync());
        }

        // GET: Transformers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transformer = await _context.Transformer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transformer == null)
            {
                return NotFound();
            }

            return View(transformer);
        }

        // GET: Transformers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transformers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Transformer transformer)
        {
            if (ModelState.IsValid)
            {
                transformer.Id = Guid.NewGuid();
                _context.Add(transformer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transformer);
        }

        // GET: Transformers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transformer = await _context.Transformer.FindAsync(id);
            if (transformer == null)
            {
                return NotFound();
            }
            return View(transformer);
        }

        // POST: Transformers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id")] Transformer transformer)
        {
            if (id != transformer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transformer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransformerExists(transformer.Id))
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
            return View(transformer);
        }

        // GET: Transformers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transformer = await _context.Transformer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transformer == null)
            {
                return NotFound();
            }

            return View(transformer);
        }

        // POST: Transformers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var transformer = await _context.Transformer.FindAsync(id);
            _context.Transformer.Remove(transformer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransformerExists(Guid id)
        {
            return _context.Transformer.Any(e => e.Id == id);
        }
    }
}
