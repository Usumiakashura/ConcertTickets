using BuissnesLayer;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CT.Controllers
{
    public class ConcertInfoController : Controller
    {
        ConcertViewModel _concert;
        private DataManager _dataManager;
        private ServicesManager _serviceManager;

        public ConcertInfoController(DataManager dataManager)
        {
            _dataManager = dataManager;
            _serviceManager = new ServicesManager(_dataManager);
        }

        public IActionResult Index(int concertId)
        {
            var c = _dataManager.Concerts.GetConcertById(concertId);
            _concert = _serviceManager.ConcertServices.ConcertDBToViewModelById(c.Id);
            return View(_concert);
        }

    }
}
