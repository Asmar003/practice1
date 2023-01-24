using bilet_5.DAL;
using bilet_5.Models;
using bilet_5.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bilet_5.Areas.Controllers
{
    [Area("Manage")]
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeVM employeeVM)
        {
            if(!ModelState.IsValid) return View();
            Employee employee = new Employee
            {
                Name=employeeVM.Name,
                Description=employeeVM.Description,
                ImageUrl=employeeVM.ImageUrl,
                SocialLink=employeeVM.SocialLink
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
