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
            //решить вопрос с бронированными билетами

            //решить вопрос с купленными билетами

            //удалить билеты

            //удалить информацию о концетре
            context.InfoAboutTypeConcerts.Remove(context.InfoAboutTypeConcerts.ElementAt(concert.InfoATC.Id));
            //удалить сам концерт
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
