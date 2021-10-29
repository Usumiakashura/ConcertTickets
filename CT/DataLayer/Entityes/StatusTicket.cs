using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class StatusTicket
    {
        public int Id { get; set; }
        public string NameStatus { get; set; }
        public List<InfoAboutTicket> InfoAboutTickets { get; set; }
        public List<InfoAboutDeleteTicket> InfoAboutDeleteTickets { get; set; }
    }
}
