using Microsoft.AspNetCore.Mvc;

namespace WorkConnect.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
