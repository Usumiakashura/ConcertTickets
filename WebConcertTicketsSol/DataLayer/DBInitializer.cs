using DataLayer.Entityes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBInitializer 
    {
        public static void InitData(ApplicationDbContext context)
        {
            List<ConcertType> CConcertTypes;
            List<VoiceType> CVoiceTypes;
            List<Concert> CConcerts;

            if (!context.ConcertTypes.Any() && !context.VoiceTypes.Any())
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
                        //Id = 1,
                        Singer = "Какой-то крутой чел",
                        DateConcert = new DateTime(2022, 02, 21, 19, 00, 00),
                        Place = "Кафе \"Маргаритка\"",
                        Image = "imgC001.jpeg",
                        InfoATC = new Party()
                        {
                            Id = 1,
                            Age = 18,
                            Note = "Дресс-код: красно-желтые цвета одежды.",
                            ConcertType = context.ConcertTypes.Find(1)
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
                        //Id = 2,
                        Singer = "БИ-2",
                        DateConcert = new DateTime(2021, 11, 26, 19, 00, 00),
                        Place = "Аэродром \"Боровая\"",
                        Image = "imgC002.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Id = 2,
                            Headliner = "\"Чёрное солнце\"",
                            HowToGetThere = "Боровая",
                            Note = "На месте будет развернут фудкорт",
                            ConcertType = context.ConcertTypes.Find(2)
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
                        //Id = 3,
                        Singer = "Бетховен",
                        DateConcert = new DateTime(2021, 11, 19, 19, 00, 00),
                        Place = "КЗ \"Минск\"",
                        Image = "imgC003.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            Id = 3,
                            NameConcert = "Лунная соната",
                            Composer = "Бетховен",
                            Note = "Какая-то заметка",
                            ConcertType = context.ConcertTypes.Find(3),
                            VoiceType = context.VoiceTypes.Find(3)
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
                        //Id = 4,
                        Singer = "MACAN",
                        DateConcert = new DateTime(2021, 11, 21, 19, 00, 00),
                        Place = "Prime Hall / Прайм Холл, Минск",
                        Image = "imgC005.jpeg",
                        InfoATC = new Party()
                        {
                            Id = 4,
                            Age = 18,
                            Note = "Молодая звезда русского хип-хопа MACAN выступит 21 ноября на сцене Prime Hall!",
                            ConcertType = context.ConcertTypes.Find(1)
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
                        //Id = 5,
                        Singer = "РОК ФЕСТ",
                        DateConcert = new DateTime(2021, 11, 13, 19, 00, 00),
                        Place = "Дворец спорта, Минск",
                        Image = "imgC004.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Id = 5,
                            Headliner = "«Агата Кристи»",
                            HowToGetThere = "м. Немига",
                            Note = "Весной 2018 Вадим Самойлов анонсировал новую концертную программу, посвященную тридцатилетию легендарной группы.",
                            ConcertType = context.ConcertTypes.Find(2)
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
                        //Id = 6,
                        Singer = "Дж.Герцевич",
                        DateConcert = new DateTime(2021, 11, 23, 19, 00, 00),
                        Place = "Брестский академический театр драмы, Брест",
                        Image = "imgC006.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            Id = 6,
                            NameConcert = "\"В СТИЛЕ БЛЮЗ\" 6+",
                            Composer = "Александр Сосноввский",
                            Note = "Какая-то заметка",
                            ConcertType = context.ConcertTypes.Find(3),
                            VoiceType = context.VoiceTypes.Find(2)
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
                        //Id = 7,
                        Singer = "Ramil'",
                        DateConcert = new DateTime(2021, 11, 05, 19, 00, 00),
                        Place = "Prime Hall / Прайм Холл, Минск",
                        Image = "imgC007.jpeg",
                        InfoATC = new Party()
                        {
                            Id = 7,
                            Age = 16,
                            Note = "Музыка Ramil’ — это смелый и резкий поп, представляющий новейшую волну поп-музыки, которая зарождается не в дорогих студиях и радиостанциях, а в «сторис» инстаграма и аудиозаписях Вконтакте.",
                            ConcertType = context.ConcertTypes.Find(1)
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
                        //Id = 8,
                        Singer = "Dabro",
                        DateConcert = new DateTime(2021, 11, 20, 19, 00, 00),
                        Place = "клуб RE:PUBLIC, Минск",
                        Image = "imgC008.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Id = 8,
                            Headliner = "Хиты Юность, Поцелуй, Я по частицам",
                            HowToGetThere = "ОАО \"МПОВТ\"",
                            Note = "Какая-нибудь большая заметка",
                            ConcertType = context.ConcertTypes.Find(2)
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
                        //Id = 9,
                        Singer = "Государственный академический симфонический оркестр Республики Беларусь",
                        DateConcert = new DateTime(2021, 11, 11, 19, 00, 00),
                        Place = "Брестский академический театр драмы, Брест",
                        Image = "imgC009.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            Id = 9,
                            NameConcert = "Цикл концертов \"Классика для всех\"",
                            Composer = "Александр Анисимов",
                            Note = "Какая-то заметка",
                            ConcertType = context.ConcertTypes.Find(3),
                            VoiceType = context.VoiceTypes.Find(2)
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
                        //Id = 10,
                        Singer = "Pain (метал / Швеция)",
                        DateConcert = new DateTime(2022, 02, 21, 19, 00, 00),
                        Place = "Аэродром \"Боровая\"",
                        Image = "imgC010.jpeg",
                        InfoATC = new OpenAir()
                        {
                            Id = 10,
                            Headliner = "\"Shut Your Mouth\"",
                            HowToGetThere = "Боровая",
                            Note = "PAIN – группа Петера Тагтгрена – мультиинструменталиста, продюсера и композитора, известного своими работами в Lindemann, Hypocrisy. ",
                            ConcertType = context.ConcertTypes.Find(2)
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
                        //Id = 11,
                        Singer = "Государственная академическая хоровая капелла им. Г. Ширмы",
                        DateConcert = new DateTime(2021, 10, 31, 19, 00, 00),
                        Place = "Белгосфилармония, Минск",
                        Image = "imgC011.jpeg",
                        InfoATC = new ClassicMusic()
                        {
                            Id = 11,
                            NameConcert = "Голоса мира",
                            Composer = "Вольга Янум",
                            Note = "Какая-то заметка",
                            ConcertType = context.ConcertTypes.Find(3),
                            VoiceType = context.VoiceTypes.Find(1)
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

        public static async Task Seed(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // создать БД, если она еще не создана
            context.Database.EnsureCreated();
            // проверка наличия ролей
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                // создать роль admin
                await roleManager.CreateAsync(roleAdmin);
            }
            // проверка наличия пользователей
            if (!context.Users.Any())
            {
                // создать пользователя user@mail.ru
                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru"
                };
                await userManager.CreateAsync(user, "123456");
                // создать пользователя admin@mail.ru
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "123456");
                // назначить роль admin
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }
        }
    }
}
