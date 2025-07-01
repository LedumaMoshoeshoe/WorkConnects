using Microsoft.AspNetCore.Mvc;

namespace WorkConnect.Controllers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
