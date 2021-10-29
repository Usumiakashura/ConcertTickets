using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entityes
{
    public class DeletedTicked
    {
        [Key]
        public int DelTicketId { get; set; }
        public string SingerDeletedConcert { get; set; }
        public DateTime? DateConcert { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Sector { get; set; }

        public List<InfoAboutDeleteTicket> InfoAboutDeleteTickets { get; set; }


    }
}
