using BuissnesLayer.Interfaces;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Implementations
{
    class EFConcertTypesRepository : IConcertTypesRepository
    {
        public void DeleteConcertType(ConcertType concertType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConcertType> GetAllConcertTypes(bool includeConcert = false)
        {
            throw new NotImplementedException();
        }

        public ConcertType GetConcertTypeById(int concertId, bool includeConcert = false)
        {
            throw new NotImplementedException();
        }

        public void SaveConcertType(ConcertType concertType)
        {
            throw new NotImplementedException();
        }
    }
}
