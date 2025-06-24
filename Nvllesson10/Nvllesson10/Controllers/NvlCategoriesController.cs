using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nvllesson10.Models;

namespace Nvllesson10.Controllers
{
    public class NvlCategoriesController : Controller
    {
        private readonly NvlK23cnt2lesson10Context _context;

        public NvlCategoriesController(NvlK23cnt2lesson10Context context)
        {
            _context = context;
        }

        // GET: NvlCategories
        public async Task<IActionResult> NvlIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: NvlCategories/NvlDetails/5
        public async Task<IActionResult> NvlDetails(int? nvlId)
        {
            if (nvlId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == nvlId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: NvlCategories/NvlCreate
        public IActionResult NvlCreate()
        {
            return View();
        }

        // POST: NvlCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvlCreate([Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: NvlCategories/NvlEdit/5
        public async Task<IActionResult> NvlEdit(int? nvlId)
        {
            if (nvlId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(nvlId);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: NvlCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvlEdit(int nvlId, [Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (nvlId != category.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NvlIndex));
            }
            return View(category);
        }

        // GET: NvlCategories/NvlDelete/5
        public async Task<IActionResult> NvlDelete(int? nvlId)
        {
            if (nvlId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == nvlId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: NvlCategories/NvlDelete/5
        [HttpPost, ActionName("NvlDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int nvlId)
        {
            var category = await _context.Categories.FindAsync(nvlId);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvlIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CateId == id);
        }
    }
}
