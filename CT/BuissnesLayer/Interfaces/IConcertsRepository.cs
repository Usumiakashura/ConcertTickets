using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IConcertsRepository
    {
        IEnumerable<Concert> GetAllConcerts(/*bool includeTypeConcert = false*/);
        Concert GetConcertById(int concertId/*, bool includeTypeConcert = false*/);
        void SaveConcert(Concert concert);
        void DeleteConcert(Concert concert);

    }
}
