using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    public class ConcertViewModel 
    {
        public Concert Concert { get; set; }
        public int Id { get; set; }
        public string Singer { get; set; }
        public DateTime? DateConcert { get; set; }
        public string Place { get; set; }
        public string Image { get; set; }
        public InfoAboutTypeConcert InfoAboutTypeConcert { get; set; }
        public List<TicketViewModel> Tickets { get; set; }

        public ConcertViewModel()
        {
            Tickets = new List<TicketViewModel>();
        }

    }

}
