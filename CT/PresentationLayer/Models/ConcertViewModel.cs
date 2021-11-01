using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    public class ConcertViewModel 
    {
        public Concert Concert { get; set; }
        public InfoAboutTypeConcert InfoAboutTypeConcert { get; set; }
        public List<TicketViewModel> Tickets { get; set; }

        public ConcertViewModel()
        {
            Tickets = new List<TicketViewModel>();
        }

    }

}
