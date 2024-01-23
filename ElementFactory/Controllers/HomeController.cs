using ElementFactory.Data;
using ElementFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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

        public IActionResult Index()
        {
            return RedirectToAction("Welcome");
        }

        public async Task<IActionResult> LoadTable()
        {
            var elements = this._context
                .ChemicalElements
                .Include(x => x.ChemicalType)
                .OrderBy(x => x.AtomicNumber)
                .ToList();

            return View("Index", elements);
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, 
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            { RequestId = Activity.Current?.Id ?? 
            HttpContext.TraceIdentifier });
        }
    }
}