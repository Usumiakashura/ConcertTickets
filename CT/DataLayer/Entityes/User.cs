using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class User
    {
        public int Id { get; set; }
        //public string Login { get; set; }
        //public string Password { get; set; }
        public string EMail { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Photo { get; set; }

        public List<InfoAboutTicket> InfoAboutTickets { get; set; }
        public List<InfoAboutDeleteTicket> InfoAboutDeleteTickets { get; set; }
    }
}
