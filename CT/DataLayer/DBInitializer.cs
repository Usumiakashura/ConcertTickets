using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DBInitializer 
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
                        NameType = "Party"
                    },
                    new ConcertType()
                    {
                        NameType = "Open Air"
                    },
                    new ConcertType()
                    {
                        NameType = "Classic Music"
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
                        DateConcert = new DateTime(2022, 02, 21),
                        Place = "Кафе \"Маргаритка\"",
                        Image = "imgC001.jpeg",
                        InfoATC = new Party()
                        {
                            Age = 18,
                            Note = "Дресс-код: красно-желтые цвета одежды.",
                            ConcertTypeId = context.ConcertTypes.Find(1).Id
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
                        DateConcert = new DateTime(2021, 11, 26),
                        Place = "Аэродром \"Боровая\"",
                        Image = "imgC002.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Headliner = "\"Чёрное солнце\"",
                            HowToGetThere = "Боровая",
                            Note = "На месте будет развернут фудкорт",
                            ConcertTypeId = context.ConcertTypes.Find(2).Id
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
                        DateConcert = new DateTime(2021, 11, 19),
                        Place = "КЗ \"Минск\"",
                        Image = "imgC003.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            NameConcert = "Лунная соната",
                            Composer = "Бетховен",
                            Note = "Какая-то заметка",
                            ConcertTypeId = context.ConcertTypes.Find(3).Id,
                            VoiceTypeId = context.VoiceTypes.Find(3).Id
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
                    },
                    new Concert()
                    {
                        Singer = "MACAN",
                        DateConcert = new DateTime(2021, 11, 21),
                        Place = "Prime Hall / Прайм Холл, Минск",
                        Image = "imgC005.jpeg",
                        InfoATC = new Party()
                        {
                            Age = 18,
                            Note = "Молодая звезда русского хип-хопа MACAN выступит 21 ноября на сцене Prime Hall!",
                            ConcertTypeId = context.ConcertTypes.Find(1).Id
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
                        Singer = "РОК ФЕСТ",
                        DateConcert = new DateTime(2021, 11, 13),
                        Place = "Дворец спорта, Минск",
                        Image = "imgC004.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Headliner = "«Агата Кристи»",
                            HowToGetThere = "м. Немига",
                            Note = "Весной 2018 Вадим Самойлов анонсировал новую концертную программу, посвященную тридцатилетию легендарной группы.",
                            ConcertTypeId = context.ConcertTypes.Find(2).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 50,
                                Price = 74,
                                Sector = "Фанзона"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 70,
                                Price = 104,
                                Sector = "Б"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 70,
                                Price = 74,
                                Sector = "B"
                            }
                        }
                    },
                    new Concert()
                    {
                        Singer = "Дж.Герцевич",
                        DateConcert = new DateTime(2021, 11, 23),
                        Place = "Брестский академический театр драмы, Брест",
                        Image = "imgC006.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            NameConcert = "\"В СТИЛЕ БЛЮЗ\" 6+",
                            Composer = "Александр Сосноввский",
                            Note = "Какая-то заметка",
                            ConcertTypeId = context.ConcertTypes.Find(3).Id,
                            VoiceTypeId = context.VoiceTypes.Find(2).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 12,
                                Price = 15,
                                Sector = "Балкон"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 60,
                                Price = 18,
                                Sector = "Партер"
                            }
                        }
                    },
                    new Concert()
                    {
                        Singer = "Ramil'",
                        DateConcert = new DateTime(2021, 11, 05),
                        Place = "Prime Hall / Прайм Холл, Минск",
                        Image = "imgC007.jpeg",
                        InfoATC = new Party()
                        {
                            Age = 16,
                            Note = "Музыка Ramil’ — это смелый и резкий поп, представляющий новейшую волну поп-музыки, которая зарождается не в дорогих студиях и радиостанциях, а в «сторис» инстаграма и аудиозаписях Вконтакте.",
                            ConcertTypeId = context.ConcertTypes.Find(1).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 30,
                                Price = 58,
                                Sector = "Танцпол"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 30,
                                Price = 63,
                                Sector = "А"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 30,
                                Price = 73,
                                Sector = "Б"
                            }
                        }

                    },
                    new Concert()
                    {
                        Singer = "Dabro",
                        DateConcert = new DateTime(2021, 11, 20),
                        Place = "клуб RE:PUBLIC, Минск",
                        Image = "imgC008.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Headliner = "Хиты Юность, Поцелуй, Я по частицам",
                            HowToGetThere = "ОАО \"МПОВТ\"",
                            Note = "Какая-нибудь большая заметка",
                            ConcertTypeId = context.ConcertTypes.Find(2).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 12,
                                Price = 58,
                                Sector = "Танцпол"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 50,
                                Price = 78,
                                Sector = "А"
                            }
                        }
                    },
                    new Concert()
                    {
                        Singer = "Государственный академический симфонический оркестр Республики Беларусь",
                        DateConcert = new DateTime(2021, 11, 11),
                        Place = "Брестский академический театр драмы, Брест",
                        Image = "imgC009.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            NameConcert = "Цикл концертов \"Классика для всех\"",
                            Composer = "Александр Анисимов",
                            Note = "Какая-то заметка",
                            ConcertTypeId = context.ConcertTypes.Find(3).Id,
                            VoiceTypeId = context.VoiceTypes.Find(2).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 12,
                                Price = 15,
                                Sector = "Балкон"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 60,
                                Price = 17,
                                Sector = "Партер"
                            }
                        }
                    },
                    new Concert()
                    {
                        Singer = "Pain (метал / Швеция)",
                        DateConcert = new DateTime(2022, 02, 21),
                        Place = "Аэродром \"Боровая\"",
                        Image = "imgC010.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Headliner = "\"Shut Your Mouth\"",
                            HowToGetThere = "Боровая",
                            Note = "PAIN – группа Петера Тагтгрена – мультиинструменталиста, продюсера и композитора, известного своими работами в Lindemann, Hypocrisy. ",
                            ConcertTypeId = context.ConcertTypes.Find(2).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 50,
                                Price = 58,
                                Sector = "Танцпол"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 70,
                                Price = 83,
                                Sector = "А"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 70,
                                Price = 83,
                                Sector = "B"
                            }
                        }
                    },
                    new Concert()
                    {
                        Singer = "Государственная академическая хоровая капелла им. Г. Ширмы",
                        DateConcert = new DateTime(2021, 10, 31),
                        Place = "Белгосфилармония, Минск",
                        Image = "imgC011.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            NameConcert = "Голоса мира",
                            Composer = "Вольга Янум",
                            Note = "Какая-то заметка",
                            ConcertTypeId = context.ConcertTypes.Find(3).Id,
                            VoiceTypeId = context.VoiceTypes.Find(1).Id
                        },
                        Tickets = new List<Ticket>()
                        {
                            new Ticket()
                            {
                                NumOfTickets = 14,
                                Price = 12,
                                Sector = "Балкон"
                            },
                            new Ticket()
                            {
                                NumOfTickets = 100,
                                Price = 13,
                                Sector = "Партер"
                            }
                        }
                    }
                };
                context.Concerts.AddRange(CConcerts);

                context.SaveChanges();
            };

        }
    }
}
