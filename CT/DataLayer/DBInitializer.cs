using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DBInitializer //: CreateDatabaseIfNotExists<EFDBContext>
    {
        public static void InitData(EFDBContext context)
        {
            List<ConcertType> CConcertTypes;
            List<VoiceType> CVoiceTypes;
            List<Concert> CConcerts;


            if (!context.ConcertTypes.Any() && !context.VoiceTypes.Any() && !context.Concerts.Any())
            {
                CConcertTypes = new List<ConcertType>()
                {
                    new ConcertType()
                    {
                        NameType = "Classic Music"
                    },
                    new ConcertType()
                    {
                        NameType = "Open Air"
                    },
                    new ConcertType()
                    {
                        NameType = "Party"
                    }
                };
                context.ConcertTypes.AddRange(CConcertTypes);

                CVoiceTypes = new List<VoiceType>()
                {
                    new VoiceType()
                    {
                        NameVoiceType = "сопрано"
                    },
                    new VoiceType()
                    {
                        NameVoiceType = "тенор"
                    },
                    new VoiceType()
                    {
                        NameVoiceType = "баритон"
                    }
                };
                context.VoiceTypes.AddRange(CVoiceTypes);

                context.SaveChanges();
            };

            if (!context.Concerts.Any())
            {
                CConcerts = new List<Concert>()
                {
                    new Concert()
                    {
                        Singer = "Какой-то крутой чел",
                        DateConcert = new DateTime(2021, 11, 01),
                        Place = "Кафе \"Маргаритка\"",
                        Image = "imgC001.jpeg",
                        InfoATC = new Party()
                        {
                            Age = 18,
                            Note = "Дресс-код: красно-желтые цвета одежды."
                            
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 30,
                                Price = 10,
                                Sector = "Танцпол"
                            }
                        }

                    },
                    new Concert()
                    {
                        Singer = "БИ-2",
                        DateConcert = new DateTime(2021, 11, 07),
                        Place = "Аэродром \"Боровая\"",
                        Image = "imgC002.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Headliner = "\"Чёрное солнце\"",
                            HowToGetThere = "Боровая",
                            Note = "На месте будет развернут фудкорт"
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 50,
                                Price = 80,
                                Sector = "Фанзона"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 70,
                                Price = 60,
                                Sector = "А"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 70,
                                Price = 40,
                                Sector = "B"
                            }
                        }
                    },
                    new Concert()
                    {
                        Singer = "Бетховен",
                        DateConcert = new DateTime(2021, 11, 11),
                        Place = "КЗ \"Минск\"",
                        Image = "imgC002.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            NameConcert = "Лунная соната",
                            Composer = "Бетховен",
                            Note = "Какая-то заметка"
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 40,
                                Price = 50,
                                Sector = "A"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 100,
                                Price = 30,
                                Sector = "B"
                            }
                        }
                    }
                };
                context.Concerts.AddRange(CConcerts);

                context.SaveChanges();
            };

            context.InfoAboutTypeConcerts.Find(1).ConcertTypeId = context.ConcertTypes.Find(3).Id;
            context.InfoAboutTypeConcerts.Find(2).ConcertTypeId = context.ConcertTypes.Find(2).Id;
            context.InfoAboutTypeConcerts.Find(3).ConcertTypeId = context.ConcertTypes.Find(1).Id;

            context.ClassicMusics.Find(3).VoiceTypeId = context.VoiceTypes.Find(3).Id;

            context.SaveChanges();
        }
    }
}
