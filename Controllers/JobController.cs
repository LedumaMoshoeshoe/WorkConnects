using Microsoft.AspNetCore.Mvc;

namespace WorkConnect.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
