using ElementFactory.Data;
using ElementFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
namespace ElementFactory.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var elements = this._context.ChemicalElements.OrderBy(x=>x.AtomicNumber).ToList();
            return View(elements);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            { RequestId = Activity.Current?.Id ?? 
            HttpContext.TraceIdentifier });
        }
    }
}