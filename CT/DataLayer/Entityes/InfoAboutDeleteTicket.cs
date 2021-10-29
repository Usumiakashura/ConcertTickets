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
        public DeletedTicket DeletedTicket { get; set; }
        public int StatusTicketId { get; set; }
        public StatusTicket StatusTicket { get; set; }
        public int NumTicket { get; set; }
    }
}
