using BuissnesLayer;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer
{
    public class ServicesManager
    {
        DataManager _dataManager;
        private ConcertService _concertService;
        private ConcertTypeService _concertTypeService;
        private TicketService _ticketService;

        public ServicesManager(
            DataManager dataManager)
        {
            _dataManager = dataManager;
            _concertService = new ConcertService(_dataManager);
            _concertTypeService = new ConcertTypeService(_dataManager);
            _ticketService = new TicketService(_dataManager);
        }
        public ConcertService ConcertServices { get { return _concertService; } }
        public ConcertTypeService ConcertTypeServices { get { return _concertTypeService; } }
        public TicketService TicketServices { get { return _ticketService; } }
    }
}
