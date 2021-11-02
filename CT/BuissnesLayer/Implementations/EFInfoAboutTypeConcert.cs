using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFInfoAboutTypeConcert : IInfoAboutTypeConcert
    {
        private EFDBContext _context;

        public EFInfoAboutTypeConcert(EFDBContext context)
        {
            _context = context;
        }

        public InfoAboutTypeConcert GetInfoAboutTypeConcertByIdConcert(int concertId)
        {
            return _context.InfoAboutTypeConcerts.Find(concertId);
        }

        public void SaveConcertType(InfoAboutTypeConcert infoATC)
        {
            throw new NotImplementedException();
        }
    }
}
