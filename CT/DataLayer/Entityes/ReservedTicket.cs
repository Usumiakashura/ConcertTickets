﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class ReservedTicket
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }


    }
}
