using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cakes_N_Treats_By_Zannie.Models;
using Cakes_N_Treats_By_Zannie.Implementations.Services;
using Microsoft.AspNetCore.Authorization;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;

namespace Cakes_N_Treats_By_Zannie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITreatService TreatService;

        public HomeController(ILogger<HomeController> logger,ITreatService treatService)
        {
            _logger = logger;
            TreatService=treatService;
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
        
        public IActionResult Contact()
        {
            return View();
        }public IActionResult TryIndex()
        {
            return View();
        }
    }
}
