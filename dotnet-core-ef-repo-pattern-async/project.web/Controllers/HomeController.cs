using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.web.Core.Repos.Interfaces;
using project.web.Models;
using Serilog;

namespace project.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly ISampleRepo _sampleRepo;

        public HomeController(ILogger logger, ISampleRepo sampleRepo)
        {
            _logger = logger;
            _sampleRepo = sampleRepo;
        }

        public IActionResult Index()
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
