using BuissnesLayer;
using DataLayer.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class ConcertService
    {
        private DataManager _dataManager;
        private TicketService _ts;

        public ConcertService(DataManager dataManager)
        {
            _dataManager = dataManager;
            _ts = new TicketService(_dataManager);
        }

        public List<ConcertViewModel> GetConcertsList()
        {
            var _dirs = _dataManager.Concerts.GetAllConcerts();
            List<ConcertViewModel> _modelList = new List<ConcertViewModel>();
            if (_dirs != null) 
            {
                foreach (var item in _dirs)
                {
                    _modelList.Add(ConcertDBToViewModelById(item.Id));
                }
            }            
            return _modelList;
        }

        public ConcertViewModel ConcertDBToViewModelById(int concertId)
        {
            var c = _dataManager.Concerts.GetConcertById(concertId);
            return new ConcertViewModel()
            {
                Concert = c,
                InfoAboutTypeConcert = _dataManager.InfoAboutTypeConcerts.GetInfoAboutTypeConcertByIdConcert(concertId),
                Tickets = _ts.GetTicketsList(c)
            };
        }



    }
}
