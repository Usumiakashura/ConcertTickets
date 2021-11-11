using BuissnesLayer;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConcertTickets.Controllers
{
    public class ConcertInfoController : Controller
    {
        private DataManager _dataManager;
        Concert _concert;

        public ConcertInfoController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        // страница просмотра основной информации о концерте
        public IActionResult Index(Concert concert)
        {
            _concert = concert;
            return View(_concert);
        }

        //страница редактирования концерта
        public IActionResult EditInfoAboutConcert(Concert concert)
        {
            _concert = concert;
            return View(_concert);
        }

        [HttpPost]
        public ActionResult EditConcert(Concert concert)
        {
            //_dataManager.Concerts.SaveConcert(_serviceManager.ConcertServices.ConcertViewModelToDB(c));


            //if (concert.InfoAboutTypeConcert is ClassicMusic)
            //    _dataManager.InfoAboutTypeConcerts.SaveConcertType(((ClassicMusic)c.InfoAboutTypeConcert));
            //if (concert.InfoAboutTypeConcert is OpenAir)
            //    _dataManager.InfoAboutTypeConcerts.SaveConcertType(((OpenAir)c.InfoAboutTypeConcert));
            //if (concert.InfoAboutTypeConcert is Party)
            //    _dataManager.InfoAboutTypeConcerts.SaveConcertType(((Party)c.InfoAboutTypeConcert));
            //_concert = _serviceManager.ConcertServices.GetConcertById(c.Id);
            return View("Index", concert);
        }

    }
}
