using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkConnect.Data;
using WorkConnect.Models;
using System.Linq;
using System.Threading.Tasks;

namespace WorkConnect.Controllers
{
    public class JobController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Job
        public async Task<IActionResult> Index()
        {
            var jobs = await _context.Job
                .OrderByDescending(j => j.PostedAt)
                .ToListAsync();
            return View(jobs);
        }

        // GET: /Job/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var job = await _context.Job.FirstOrDefaultAsync(m => m.Id == id);
            if (job == null) return NotFound();

            return View(job);
        }

        // GET: /Job/Create
        public IActionResult Create() => View();

        // POST: /Job/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Job job)
        {
            if (ModelState.IsValid)
            {
                job.PostedAt = System.DateTime.UtcNow;
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: /Job/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var job = await _context.Job.FindAsync(id);
            if (job == null) return NotFound();
            return View(job);
        }

        // POST: /Job/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Job job)
        {
            if (id != job.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Job.Any(e => e.Id == job.Id)) return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: /Job/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var job = await _context.Job.FirstOrDefaultAsync(m => m.Id == id);
            if (job == null) return NotFound();
            return View(job);
        }

        // POST: /Job/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await _context.Job.FindAsync(id);
            if (job != null)
            {
                _context.Job.Remove(job);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
