using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using transformers_battle_sim.Data;
using transformers_battle_sim.Data.Interface;
using transformers_battle_sim.Models.Transformer.Impl;
using transformers_battle_sim.Models.Character.Interface;

namespace transformers_battle_sim.Controllers
{
    public class TransformersController : Controller
    {
        private readonly IRepository _repo;

        public TransformersController(IRepository repo)
        {
            _repo = repo;
        }

        // GET: Transformers
        public async Task<IActionResult> Index()
        {
            //return View(await _repo.Transformer.ToListAsync());
            var genericList = _repo.GetCharacterList();
            List<Transformer> tfList = new List<Transformer>();
            foreach(var tf in genericList)
            {
                tfList.Add((Transformer)tf);
            }
            return View(tfList);
        }

        // GET: Transformers/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var transformer = await _repo.Transformer
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (transformer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(transformer);
        //}

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
        public async Task<IActionResult> Create([Bind("Id,Name,Faction,WinCount,LossCount")] Transformer transformer)
        {

                transformer.Id = Guid.NewGuid();
                transformer.LossCount = 0;
                transformer.WinCount = 0;
                _repo.AddCharacter(transformer);
                return RedirectToAction(nameof(Index));
        }

        // GET: Transformers/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var transformer = await _repo.Transformer.FindAsync(id);
        //    if (transformer == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(transformer);
        //}

        //// POST: Transformers/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id")] Transformer transformer)
        //{
        //    if (id != transformer.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _repo.Update(transformer);
        //            await _repo.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TransformerExists(transformer.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(transformer);
        //}

        // GET: Transformers/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var transformer = await _repo.Transformer
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (transformer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(transformer);
        //}

        // POST: Transformers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            //var transformer = await _repo.Transformer.FindAsync(id);
            //_repo.Transformer.Remove(transformer);
            //await _repo.SaveChangesAsync();

            var transformer = _repo.RetrieveCharacter(id);
            _repo.RemoveCharacter(transformer);
            return RedirectToAction(nameof(Index));
        }

        //private bool TransformerExists(Guid id)
        //{
        //    return _repo.Transformer.Any(e => e.Id == id);
        //}
    }
}
