using BuissnesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebConcertTickets.Models;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebConcertTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataManager _dataManager;
        //private List<Concert> _listConcerts;
        private List<ConcertType> _listConcertTypes;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;

            //_listConcerts = new List<Concert>();
            //foreach (var c in _dataManager.Concerts.GetAllConcerts())
            //{
            //    _listConcerts.Add(c);
            //}

            _listConcertTypes = new List<ConcertType>() { new ConcertType() { NameType = "Выберите тип концерта..."} };
            foreach (var ct in _dataManager.ConcertTypess.GetAllConcertTypes())
            {
                _listConcertTypes.Add(ct);
            }
        }

        public IActionResult Index()
        {
            ViewData["ListCT"] = new SelectList(_listConcertTypes);
            return View(_dataManager.Concerts.GetAllConcerts());
        }

    }
}
