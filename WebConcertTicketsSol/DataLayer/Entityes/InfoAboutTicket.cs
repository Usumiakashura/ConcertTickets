using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class InfoAboutTicket
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int StatusTicketId { get; set; }
        public StatusTicket StatusTicket { get; set; }
        public int NumTicket { get; set; }
    }
}
