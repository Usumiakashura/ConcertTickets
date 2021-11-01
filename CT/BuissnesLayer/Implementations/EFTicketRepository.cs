using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFTicketRepository : ITicketsRepository
    {
        private EFDBContext _context;

        public EFTicketRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Ticket> GetAllTicketsByIdConcert(int concertId)
        {
            return _context.Tickets.Where(i => i.Concert.Id == concertId);
        }

        public Ticket GetTicketById(int ticketId)
        {
            return _context.Tickets.ElementAtOrDefault(ticketId);
        }

        public void DeleteAllTickets(Concert concert)
        {
            //----- 1. Дублируем информацию о билетах концерта в специальные таблицы -----

            foreach (var t in concert.Tickets) // цикл по списку всех билетов концерта
            {
                TicketInTableForDeletedTicket(t, concert);
            }

            //----- 2. Удаляем билеты -----
            foreach (var t in _context.Tickets.Where(n => n.Concert.Id == concert.Id))
                _context.Tickets.Remove(t);
        }

        void TicketInTableForDeletedTicket(Ticket ticket, Concert concert)
        {
            _context.DeletedTickets.Add(new DeletedTicket() // дублирование информации в таблицу DeletedTicket
            {
                DelTicketId = ticket.TicketID,
                SingerDeletedConcert = concert.Singer,
                DateConcert = concert.DateConcert,
                Image = concert.Image,
                Price = ticket.Price,
                Sector = ticket.Sector
            });

            // цикл, который проходится по списку информации, которая относится именно к текущему билету
            foreach (var it in ticket.InfoAboutTickets.Where(i => i.TicketId == ticket.TicketID))
            {
                // объект для дублирования данных об удаляемых билетах
                InfoAboutDeleteTicket iadt = new InfoAboutDeleteTicket()
                {
                    DeletedTicketId = it.TicketId,
                    UserId = it.UserId,
                    StatusTicketId = it.StatusTicketId,
                    NumTicket = it.NumTicket
                };
                // добавляет в таблицу InfoAboutDeleteTickets
                _context.InfoAboutDeleteTickets.Add(iadt);
                //добавляет в список информации о бронированных купленных билетах, которые были удалены
                _context.Users.ElementAt(iadt.UserId).InfoAboutDeleteTickets.Add(iadt);
            }
        }

        public void DeleteTicket(Ticket ticket, Concert concert)
        {
            TicketInTableForDeletedTicket(ticket, concert);
            _context.Tickets.Remove(ticket);
        }

        public void SaveTicket(Ticket ticket, Concert concert)
        {
            if (ticket.TicketID == 0)
                _context.Concerts.ElementAtOrDefault(concert.Id).Tickets.Add(ticket);
            else
                _context.Entry(ticket).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
