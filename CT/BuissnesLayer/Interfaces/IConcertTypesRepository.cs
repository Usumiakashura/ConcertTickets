using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IConcertTypesRepository
    {
        IEnumerable<ConcertType> GetAllConcertTypes();
        ConcertType GetConcertTypeById(int concertTypeId);
        void SaveConcertType(ConcertType concertType);
        void DeleteConcertType(ConcertType concertType);
    }
}
