using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Data;
using ManagementSystem.Models.IMS;

namespace ManagementSystem.Controllers
{
    public class InitialReportsController : Controller
    {
        private readonly MSContext _context;

        public InitialReportsController(MSContext context)
        {
            _context = context;
        }

        // GET: InitialReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.InitialReport.ToListAsync());
        }

        // GET: InitialReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var initialReport = await _context.InitialReport
                .FirstOrDefaultAsync(m => m.Id == id);
            if (initialReport == null)
            {
                return NotFound();
            }

            return View(initialReport);
        }

        // GET: InitialReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InitialReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,IRNumber,IncidentDate,ReportedDate,Details,IncidentLocation,Status")] InitialReport initialReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(initialReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(initialReport);
        }

        // GET: InitialReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var initialReport = await _context.InitialReport.FindAsync(id);
            if (initialReport == null)
            {
                return NotFound();
            }
            return View(initialReport);
        }

        // POST: InitialReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,IRNumber,IncidentDate,ReportedDate,Details,IncidentLocation,Status")] InitialReport initialReport)
        {
            if (id != initialReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(initialReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InitialReportExists(initialReport.Id))
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
            return View(initialReport);
        }

        // GET: InitialReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var initialReport = await _context.InitialReport
                .FirstOrDefaultAsync(m => m.Id == id);
            if (initialReport == null)
            {
                return NotFound();
            }

            return View(initialReport);
        }

        // POST: InitialReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var initialReport = await _context.InitialReport.FindAsync(id);
            _context.InitialReport.Remove(initialReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InitialReportExists(int id)
        {
            return _context.InitialReport.Any(e => e.Id == id);
        }
    }
}
