using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecipeApp.Models;

namespace RecipeApp.Controllers
{
    [Authorize(Policy = "readpolicy")]
    public class ManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Manager
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recipes.ToListAsync());
        }

        // GET: Manager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);
        }

        // GET: Manager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Details,Url,Ing001,Ing002,Ing003,Ing004,Ing005,Ing006,Ing007,Ing008,Ing009,Ing010,Ing011,Ing012,Ing013,Ing014,Ing015,Ing016,Ing017,Ing018,Ing019,Ing020,Ing021,Ing022,Ing023,Ing024,Ing025,Ing026,Ing027,Ing028,Ing029,Ing030,Ing031,Ing032,Ing033,Ing034,Ing035,Ing036,Ing037,Ing038,Ing039,Ing040,Ing041,Ing042,Ing043,Ing044,Ing045,Ing046,Ing047,Ing048,Ing049,Ing050,Ing051,Ing052,Ing053,Ing054,Ing055,Ing056,Ing057,Ing058,Ing059,Ing060,Ing061,Ing062,Ing063,Ing064,Ing065,Ing066,Ing067,Ing068,Ing069,Ing070,Ing071,Ing072,Ing073,Ing074,Ing075,Ing076,Ing077,Ing078,Ing079,Ing080,Ing081,Ing082,Ing083,Ing084,Ing085,Ing086,Ing087,Ing088,Ing089,Ing090,Ing091,Ing092,Ing093,Ing094,Ing095,Ing096,Ing097,Ing098,Ing099,Ing100")] Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipes);
        }

        // GET: Manager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes.FindAsync(id);
            if (recipes == null)
            {
                return NotFound();
            }
            return View(recipes);
        }

        // POST: Manager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Details,Url,Ing001,Ing002,Ing003,Ing004,Ing005,Ing006,Ing007,Ing008,Ing009,Ing010,Ing011,Ing012,Ing013,Ing014,Ing015,Ing016,Ing017,Ing018,Ing019,Ing020,Ing021,Ing022,Ing023,Ing024,Ing025,Ing026,Ing027,Ing028,Ing029,Ing030,Ing031,Ing032,Ing033,Ing034,Ing035,Ing036,Ing037,Ing038,Ing039,Ing040,Ing041,Ing042,Ing043,Ing044,Ing045,Ing046,Ing047,Ing048,Ing049,Ing050,Ing051,Ing052,Ing053,Ing054,Ing055,Ing056,Ing057,Ing058,Ing059,Ing060,Ing061,Ing062,Ing063,Ing064,Ing065,Ing066,Ing067,Ing068,Ing069,Ing070,Ing071,Ing072,Ing073,Ing074,Ing075,Ing076,Ing077,Ing078,Ing079,Ing080,Ing081,Ing082,Ing083,Ing084,Ing085,Ing086,Ing087,Ing088,Ing089,Ing090,Ing091,Ing092,Ing093,Ing094,Ing095,Ing096,Ing097,Ing098,Ing099,Ing100")] Recipes recipes)
        {
            if (id != recipes.Id)
            {
                recipes.Id = id;
             //   return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipesExists(recipes.Id))
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
            return View(recipes);
        }

        // GET: Manager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);
        }

        // POST: Manager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipes = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(recipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipesExists(int id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
