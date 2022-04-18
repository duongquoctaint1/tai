using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cuahangdidong.Data;
using cuahangdidong.Models;

namespace cuahangdidong.Controllers
{
    public class didongController : Controller
    {
        private readonly cuahangdidongContext _context;

        public didongController(cuahangdidongContext context)
        {
            _context = context;
        }

        // GET: didong
        public async Task<IActionResult> Index(string bookGenre, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from b in _context.didong
                                            orderby b.ThểLoại 
                                            select b.ThểLoại;
            var didong = from b in _context.didong
                        select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                didong = didong.Where(s => s.ChứVụ!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(bookGenre))
            {
                didong = didong.Where(x => x.ThểLoại == bookGenre);
            }
            var didongThểLoạiVM = new didongGenreViewModel
            {
                ThểLoại = new SelectList(await
           genreQuery.Distinct().ToListAsync()),
               didong    = await didong.ToListAsync()
            };
            return View(didongThểLoạiVM);
        }

        // GET: didong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var didong = await _context.didong
                .FirstOrDefaultAsync(m => m.Id == id);
            if (didong == null)
            {
                return NotFound();
            }

            return View(didong);
        }

        // GET: didong/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: didong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ChứVụ,NgàyPhátHành,ThểLoại,GíaBán,SốLượng")] didong didong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(didong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(didong);
        }

        // GET: didong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var didong = await _context.didong.FindAsync(id);
            if (didong == null)
            {
                return NotFound();
            }
            return View(didong);
        }

        // POST: didong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChứVụ,NgàyPhátHành,ThểLoại,GíaBán,SốLượng")] didong didong)
        {
            if (id != didong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(didong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!didongExists(didong.Id))
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
            return View(didong);
        }

        // GET: didong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var didong = await _context.didong
                .FirstOrDefaultAsync(m => m.Id == id);
            if (didong == null)
            {
                return NotFound();
            }

            return View(didong);
        }

        // POST: didong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var didong = await _context.didong.FindAsync(id);
            _context.didong.Remove(didong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool didongExists(int id)
        {
            return _context.didong.Any(e => e.Id == id);
        }
    }
}
