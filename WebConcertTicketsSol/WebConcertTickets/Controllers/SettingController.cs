using BuissnesLayer;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConcertTickets.Controllers
{
    public class SettingController : Controller
    {
        private DataManager _dataManager;

        public SettingController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult SettingPage()
        {
            return View(_dataManager.Concerts.GetAllConcerts());
        }

        public ActionResult Edit(int concertId)
        {
            return View(_dataManager.Concerts.GetConcertById(concertId));
        }
        [HttpPost]
        public ActionResult Edit(Concert concert)
        {
            _dataManager.Concerts.SaveConcert(concert);
            return RedirectToAction("SettingPage", _dataManager.Concerts.GetAllConcerts());
        }



    }
}
