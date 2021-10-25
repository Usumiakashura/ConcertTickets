using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class ConcertType
    {
        public int Id { get; set; }
        public string NameType { get; set; }

        public List<InfoAboutTypeConcert> InfoAboutTypesConcerts { get; set; }



    }
}
