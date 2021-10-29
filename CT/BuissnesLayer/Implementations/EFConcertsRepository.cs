using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    class EFConcertsRepository : IConcertsRepository
    {
        private EFDBContext context;

        public EFConcertsRepository(EFDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Concert> GetAllConcerts()
        {
            return context.Concerts.ToList();
        }

        public Concert GetConcertById(int concertId)
        {
            return context.Concerts.FirstOrDefault(x => x.Id == concertId);
        }
        public void DeleteConcert(Concert concert)
        {
            //----- 1. Дублируем информацию о билетах концерта в специальные таблицы -----
            
            foreach (var ticket in concert.Tickets) // цикл по списку всех билетов концерта
            {
                context.DeletedTickets.Add(new DeletedTicket() // дублирование информации в таблицу DeletedTicket
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
                    context.InfoAboutDeleteTickets.Add(iadt);
                    //добавляет в список информации о бронированных купленных билетах, которые были удалены
                    context.Users.ElementAt(iadt.UserId).InfoAboutDeleteTickets.Add(iadt);  
                }
            }

            //----- 2. Удаляем билеты -----
            foreach (var t in context.Tickets.Where(n => n.Concert.Id == concert.Id))
                context.Tickets.Remove(t);

            //----- 3. Удаляем информацию о концетре -----
            context.InfoAboutTypeConcerts.Remove(context.InfoAboutTypeConcerts.ElementAt(concert.InfoATC.Id));
            
            //----- 4. Удаляем сам концерт -----
            context.Concerts.Remove(concert);
            
            context.SaveChanges();
        }

        public void SaveConcert(Concert concert)
        {
            if (concert.Id == 0)
                context.Concerts.Add(concert);
            else
                context.Entry(concert).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
