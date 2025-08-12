using Microsoft.AspNetCore.Mvc;
using WorkConnect.Models; // Make sure this is included
using System.Collections.Generic;

namespace WorkConnect.Controllers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            var workers = new List<Worker>
            {
                new Worker { FullName = "John Doe", ServiceType = "Plumbing", Location = "NYC", Languages = "English", Experience = "5 years", Phone = "1234567890", PhotoUrl = "john.jpg" },
                new Worker { FullName = "Jane Smith", ServiceType = "Cleaning", Location = "Boston", Languages = "English, Spanish", Experience = "3 years", Phone = "9876543210", PhotoUrl = "jane.jpg" }
            };

            return View(workers);
        }
    }
}
