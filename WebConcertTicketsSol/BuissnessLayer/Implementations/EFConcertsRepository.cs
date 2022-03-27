using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFConcertsRepository : IConcertsRepository
    {
        private ApplicationDbContext _context;
        private EFTicketRepository _eFTicketRepository;

        public EFConcertsRepository(ApplicationDbContext context)
        {
            _context = context;
            _eFTicketRepository = new EFTicketRepository(_context);
        }

        public IEnumerable<Concert> GetAllConcerts()
        {
            List<Concert> listConcerts = new List<Concert>();
            foreach (Concert c in _context.Concerts.Include(x => x.Tickets).Include(x => x.InfoATC).ThenInclude(x => x.ConcertType))
            {
                if (c.InfoATC is ClassicMusic)
                    ((ClassicMusic)c.InfoATC).VoiceType = _context.VoiceTypes.Include(x => x.ClassicMusics)
                        .Where(x => x.Id == ((ClassicMusic)c.InfoATC).VoiceTypeId).First();
                listConcerts.Add(c);
            }
            return listConcerts;
        }

        public Concert GetConcertById(int concertId)
        {
            Concert c = _context.Concerts.Include(x => x.Tickets)
                .Include(x => x.InfoATC)
                .ThenInclude(x => x.ConcertType)
                .Where(x => x.Id == concertId).First();
            if (c.InfoATC is ClassicMusic)
                ((ClassicMusic)c.InfoATC).VoiceType = _context.VoiceTypes.Include(x => x.ClassicMusics)
                    .Where(x => x.Id == ((ClassicMusic)c.InfoATC).VoiceTypeId).First();
            return c;
        }
        
        public void DeleteConcert(Concert concert)
        {
            _eFTicketRepository.DeleteAllTickets(concert);

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
                _context.Entry(concert).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
