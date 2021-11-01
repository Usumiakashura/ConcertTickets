using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IConcertsRepository
    {
        public IEnumerable<Concert> GetAllConcerts();
        public Concert GetConcertById(int concertId);
        public void SaveConcert(Concert concert);
        public void DeleteConcert(Concert concert);

    }
}
