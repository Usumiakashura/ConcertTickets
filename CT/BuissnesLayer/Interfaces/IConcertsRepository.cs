using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IConcertsRepository
    {
        public IEnumerable<Concert> GetAllConcerts(/*bool includeTypeConcert = false*/);
        public Concert GetConcertById(int concertId/*, bool includeTypeConcert = false*/);
        public void SaveConcert(Concert concert);
        public void DeleteConcert(Concert concert);

    }
}
