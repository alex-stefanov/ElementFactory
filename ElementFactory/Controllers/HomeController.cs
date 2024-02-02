using ElementFactory.Core.Contracts.Service;
using ElementFactory.Data;
using ElementFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ElementFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IChemicalElementService service;

        public HomeController(ILogger<HomeController> logger, 
            IChemicalElementService service) 
        {
            this.logger = logger;
            this.service = service;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Welcome");
        }

        public async Task<IActionResult> LoadTable()
        {
            var elements = await this.service.GetAllAsync();

            return View("Index", elements.ToList());
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