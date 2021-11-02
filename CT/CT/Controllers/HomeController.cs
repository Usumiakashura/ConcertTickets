using BuissnesLayer;
using BuissnesLayer.Implementations;
using BuissnesLayer.Interfaces;
using CT.Models;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CT.Controllers
{
    public class HomeController : Controller
    {
        private DataManager _dataManager;
        private ServicesManager _serviceManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
            _serviceManager = new ServicesManager(_dataManager);
        }


        public IActionResult Index()
        {
            return View(_serviceManager);
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
