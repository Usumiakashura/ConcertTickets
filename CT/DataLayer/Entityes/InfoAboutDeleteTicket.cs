using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class InfoAboutDeleteTicket
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int DeletedTicketId { get; set; }
        public DeletedTicked DeletedTicket { get; set; }
        public int StatusTickedId { get; set; }
        public StatusTicket StatusTicket { get; set; }
        public int NumTicket { get; set; }
    }
}
