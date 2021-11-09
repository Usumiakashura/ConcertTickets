using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFConcertsRepository : IConcertsRepository
    {
        private EFDBContext _context;
        private EFTicketRepository _eFTicketRepository;

        public EFConcertsRepository(EFDBContext context)
        {
            _context = context;
            _eFTicketRepository = new EFTicketRepository(_context);
        }

        public IEnumerable<Concert> GetAllConcerts()
        {
            List<Concert> listConcerts = new List<Concert>();
            foreach (Concert c in _context.Concerts)
            {
                c.InfoATC = _context.InfoAboutTypeConcerts.Find(c.Id);
                c.Tickets = _eFTicketRepository.GetAllTicketsByIdConcert(c.Id).ToList();
                listConcerts.Add(c);
            }
            
            return _context.Concerts;
        }

        public Concert GetConcertById(int concertId)
        {
            Concert c = _context.Concerts.Find(concertId);
            c.InfoATC = _context.InfoAboutTypeConcerts.Find(c.Id);
            return c;
        }
        
        public void DeleteConcert(Concert concert)
        {
            EFTicketRepository eFTicketRepository = new EFTicketRepository(_context);
            eFTicketRepository.DeleteAllTickets(concert);

            //----- 3. Удаляем информацию о концетре -----
            _context.InfoAboutTypeConcerts.Remove(_context.InfoAboutTypeConcerts.ElementAt(concert.InfoATC.Id));
            
            //----- 4. Удаляем сам концерт -----
            _context.Concerts.Remove(concert);
            
            _context.SaveChanges();
        }

        public void SaveConcert(Concert concert)
        {
            if (concert.Id == 0)
                _context.Concerts.Add(concert);
            else
                _context.Entry(concert).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
