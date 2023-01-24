using bilet_5.DAL;
using Microsoft.AspNetCore.Mvc;

namespace bilet_5.Areas.Controllers
{
    [Area("Manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
