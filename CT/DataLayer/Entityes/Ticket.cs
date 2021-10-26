using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public uint NumOfTickets { get; set; }
        public decimal Price { get; set; }
        public string Sector { get; set; }

        public Concert Concert { get; set; }
        public List<BuyTicket> BuyTickets { get; set; }
        public List<ReservedTicket> ReservedTickets { get; set; }


    }
}
