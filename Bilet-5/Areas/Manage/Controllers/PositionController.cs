using bilet_5.DAL;
using Microsoft.AspNetCore.Mvc;

namespace bilet_5.Areas.Controllers
{
    [Area("Manage")]
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;
        public PositionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
