using BuissnesLayer;
using DataLayer.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class TicketService
    {
        private DataManager _dataManager;

        public TicketService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public List<TicketViewModel> GetTicketsList(Concert concert)
        {
            var _dirs = _dataManager.Tickets.GetAllTicketsByIdConcert(concert.Id); //concert.Tickets;
            List<TicketViewModel> _modelList = new List<TicketViewModel>();
            if (_dirs != null)
            {
                foreach (var item in _dirs)
                {
                    _modelList.Add(TicketDbToViewModel(item));
                }
            }
            return _modelList;
        }

        public TicketViewModel TicketDbToViewModel(Ticket ticket)
        {
            //var _ticket = _dataManager.Tickets.GetTicketById(ticketId);
            return new TicketViewModel() { Ticket = ticket };
        }




    }
}
