using BuissnesLayer;
using DataLayer.Entityes;
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

        // страница просмотра основной информации о концерте
        public IActionResult Index(int concertId)
        {
            var c = _dataManager.Concerts.GetConcertById(concertId);
            _concert = _serviceManager.ConcertServices.ConcertDBToViewModel(c);
            return View(_concert);
        }

        // страница редактирования концерта
        public IActionResult EditInfoAboutConcert(int concertId)
        {
            var c = _dataManager.Concerts.GetConcertById(concertId);
            _concert = _serviceManager.ConcertServices.ConcertDBToViewModel(c);
            return View(_concert);
        }

        [HttpPost]
        public ActionResult EditConcert(ConcertViewModel c)
        {
            _dataManager.Concerts.SaveConcert(_serviceManager.ConcertServices.ConcertViewModelToDB(c));
            
            
            if (c.InfoAboutTypeConcert is ClassicMusic)
                _dataManager.InfoAboutTypeConcerts.SaveConcertType(((ClassicMusic)c.InfoAboutTypeConcert));
            if (c.InfoAboutTypeConcert is OpenAir)
                _dataManager.InfoAboutTypeConcerts.SaveConcertType(((OpenAir)c.InfoAboutTypeConcert));
            if (c.InfoAboutTypeConcert is Party)
                _dataManager.InfoAboutTypeConcerts.SaveConcertType(((Party)c.InfoAboutTypeConcert));
            _concert = _serviceManager.ConcertServices.GetConcertById(c.Id);
            return View("Index", _concert);
        }

    }
}
