using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanLuong_2310900060.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenVanLuong_2310900060.Controllers
{
    public class NvlEmployeesController : Controller
    {
        private readonly NguyenVanLuong2310900060Context _context;

        public NvlEmployeesController(NguyenVanLuong2310900060Context context)
        {
            _context = context;
        }

        // GET: NvlEmployees
        public async Task<IActionResult> NvlIndex()
        {
            return View(await _context.NvlEmployees.ToListAsync());
        }

        // GET: NvlEmployees/NvlDetails/5
        public async Task<IActionResult> NvlDetails(string nvlId)
        {
            if (nvlId == null)
            {
                return NotFound();
            }

            var nvlEmployee = await _context.NvlEmployees
                .FirstOrDefaultAsync(m => m.NvlEmpId == nvlId);
            if (nvlEmployee == null)
            {
                return NotFound();
            }

            return View(nvlEmployee);
        }

        // GET: NvlEmployees/NvlCreate
        public IActionResult NvlCreate()
        {
            return View();
        }

        // POST: NvlEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvlCreate([Bind("NvlEmpId,NvlEmpName,NvlEmpLevel,NvlEmpStartDate,NvlEmpStatus")] NvlEmployee nvlEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nvlEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvlIndex));
            }
            return View(nvlEmployee);
        }

        // GET: NvlEmployees/NvlEdit/5
        public async Task<IActionResult> NvlEdit(string nvlId)
        {
            if (nvlId == null)
            {
                return NotFound();
            }

            var nvlEmployee = await _context.NvlEmployees.FindAsync(nvlId);
            if (nvlEmployee == null)
            {
                return NotFound();
            }
            return View(nvlEmployee);
        }

        // POST: NvlEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvlEdit(string nvlId, [Bind("NvlEmpId,NvlEmpName,NvlEmpLevel,NvlEmpStartDate,NvlEmpStatus")] NvlEmployee nvlEmployee)
        {
            if (nvlId != nvlEmployee.NvlEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nvlEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NvlEmployeeExists(nvlEmployee.NvlEmpId))
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
            return View(nvlEmployee);
        }

        // GET: NvlEmployees/NvlDelete/5
        public async Task<IActionResult> NvlDelete(string nvlId)
        {
            if (nvlId == null)
            {
                return NotFound();
            }

            var nvlEmployee = await _context.NvlEmployees
                .FirstOrDefaultAsync(m => m.NvlEmpId == nvlId);
            if (nvlEmployee == null)
            {
                return NotFound();
            }

            return View(nvlEmployee);
        }

        // POST: NvlEmployees/NvlDelete/5
        [HttpPost, ActionName("NvlDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string nvlId)
        {
            var nvlEmployee = await _context.NvlEmployees.FindAsync(nvlId);
            if (nvlEmployee != null)
            {
                _context.NvlEmployees.Remove(nvlEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvlIndex));
        }

        private bool NvlEmployeeExists(string id)
        {
            return _context.NvlEmployees.Any(e => e.NvlEmpId == id);
        }
    }
}
