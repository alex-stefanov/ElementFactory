﻿using ElementFactory.Data;
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

        public async Task<IActionResult> Index()
        {
            var elements = this._context
                .ChemicalElements
                .Include(x => x.ChemicalType)
                .OrderBy(x => x.AtomicNumber)
                .ToList();

            var atomicMasses = new List<decimal>();

            elements.ForEach(element =>
            {
                atomicMasses.Add(element.AtomicMass);
            });

            return View(elements);
        }

        public async Task<IActionResult> Welcome()
        {
            return View();
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