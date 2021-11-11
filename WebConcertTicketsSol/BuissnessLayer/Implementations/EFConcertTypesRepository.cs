using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFConcertTypesRepository : IConcertTypesRepository
    {
        private ApplicationDbContext _context;

        public EFConcertTypesRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<ConcertType> GetAllConcertTypes()
        {
            return _context.ConcertTypes;
        }

        public ConcertType GetConcertTypeById(int concertTypeId)
        {
            return _context.ConcertTypes.ElementAtOrDefault(concertTypeId);
        }

        public void DeleteConcertType(ConcertType concertType)
        {
            _context.ConcertTypes.Remove(concertType);
        }

        public void SaveConcertType(ConcertType concertType)
        {
            if (concertType.Id == 0)
                _context.ConcertTypes.Add(concertType);
            else
                _context.Entry(concertType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }        
    }
}
