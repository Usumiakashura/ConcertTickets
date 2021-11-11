using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class Concert
    {
        public int Id { get; set; }
        public string Singer { get; set; }
        public DateTime? DateConcert { get; set; }
        public string Place { get; set; }
        public string Image { get; set; }

        public InfoAboutTypeConcert InfoATC { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
