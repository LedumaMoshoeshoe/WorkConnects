using Microsoft.AspNetCore.Mvc;
using WorkConnect.Models; // Assuming your Worker model is here

namespace WorkConnect.Controllers
{
    public class WorkerController : Controller
    {
        // Example in-memory list for testing
        private static List<Worker> _workers = new List<Worker>
        {
            new Worker { Id = 1, Name = "John Doe", JobTitle = "Electrician" },
            new Worker { Id = 2, Name = "Jane Smith", JobTitle = "Plumber" }
        };

        // GET: Worker
        public IActionResult Index()
        {
            return View(_workers);
        }

        // GET: Worker/Details/5
        public IActionResult Details(int id)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);
            if (worker == null) return NotFound();
            return View(worker);
        }

        // GET: Worker/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Worker/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Worker worker)
        {
            if (ModelState.IsValid)
            {
                worker.Id = _workers.Any() ? _workers.Max(w => w.Id) + 1 : 1;
                _workers.Add(worker);
                return RedirectToAction(nameof(Index));
            }
            return View(worker);
        }

        // GET: Worker/Edit/5
        public IActionResult Edit(int id)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);
            if (worker == null) return NotFound();
            return View(worker);
        }

        // POST: Worker/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Worker worker)
        {
            var existing = _workers.FirstOrDefault(w => w.Id == id);
            if (existing == null) return NotFound();

            if (ModelState.IsValid)
            {
                existing.Name = worker.Name;
                existing.JobTitle = worker.JobTitle;
                return RedirectToAction(nameof(Index));
            }
            return View(worker);
        }

        // GET: Worker/Delete/5
        public IActionResult Delete(int id)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);
            if (worker == null) return NotFound();
            return View(worker);
        }

        // POST: Worker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);
            if (worker != null)
            {
                _workers.Remove(worker);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
