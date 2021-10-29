using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IConcertTypesRepository
    {
        IEnumerable<ConcertType> GetAllConcertTypes(bool includeConcert = false);
        ConcertType GetConcertTypeById(int concertId, bool includeConcert = false);
        void SaveConcertType(ConcertType concertType);
        void DeleteConcertType(ConcertType concertType);
    }
}
