﻿using BuissnesLayer;
using BuissnesLayer.Implementations;
using BuissnesLayer.Interfaces;
using CT.Models;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CT.Controllers
{
    public class HomeController : Controller
    {
        //private EFDBContext _context;
        //private IConcertsRepository _concRep;
        private DataManager _dataManager;

        public HomeController(/*EFDBContext context, EFConcertsRepository concRep, */DataManager dataManager)
        {
            //_context = context;
            //_concRep = concRep;
            _dataManager = dataManager;
        }


        public IActionResult Index()
        {
            //List<Concert> _dirs = _context.Concerts.ToList();
            //List<Concert> _dirs = _concRep.GetAllConcerts().ToList();
            List<Concert> _dirs = _dataManager.Concerts.GetAllConcerts().ToList();

            return View(_dirs);
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
