using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oishiness.Data;

namespace Oishiness.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public MenuController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Platillos.Include(p => p.Categoria);
            return View(await applicationDbContext.ToListAsync());
        }

    }
}
