using BuissnesLayer;
using DataLayer.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class ConcertService
    {
        private DataManager _dataManager;
        private TicketService _ts;

        public ConcertService(DataManager dataManager)
        {
            _dataManager = dataManager;
            _ts = new TicketService(_dataManager);
        }

        public List<ConcertViewModel> GetConcertsList()
        {
            var _dirs = _dataManager.Concerts.GetAllConcerts();
            List<ConcertViewModel> _modelList = new List<ConcertViewModel>();
            if (_dirs != null) 
            {
                foreach (var item in _dirs)
                {
                    _modelList.Add(ConcertDBToViewModel(item));
                }
            }            
            return _modelList;
        }

        public ConcertViewModel GetConcertById(int id)
        {
            var c = _dataManager.Concerts.GetConcertById(id);
            return ConcertDBToViewModel(c);
        }

        public ConcertViewModel ConcertDBToViewModel(Concert c)
        {
            //var c = _dataManager.Concerts.GetConcertById(concert.Id);
            ConcertViewModel cvm = new ConcertViewModel()
            {
                //Concert = c,
                Id = c.Id,
                Singer = c.Singer,
                DateConcert = c.DateConcert,
                Place = c.Place,
                Image = c.Image,
                InfoAboutTypeConcert = _dataManager.InfoAboutTypeConcerts.GetInfoAboutTypeConcertById(c.InfoATC.Id),
                Tickets = _ts.GetTicketsList(c)
            };


            return cvm;
        }

        public Concert ConcertViewModelToDB(ConcertViewModel c)
        {
            Concert concert = new Concert()
            {
                Id = c.Id,
                Singer = c.Singer,
                DateConcert = c.DateConcert,
                Place = c.Place,
                Image = c.Image
            };
            if (c.InfoAboutTypeConcert is ClassicMusic)
            {
                concert.InfoATC = new ClassicMusic()
                {
                    Note = c.InfoAboutTypeConcert.Note,
                    NameConcert = ((ClassicMusic)c.InfoAboutTypeConcert).NameConcert,
                    Composer = ((ClassicMusic)c.InfoAboutTypeConcert).Composer,
                    VoiceType = ((ClassicMusic)c.InfoAboutTypeConcert).VoiceType
                };
            }
            else if (c.InfoAboutTypeConcert is Party)
            {
                concert.InfoATC = new Party()
                {
                    Note = c.InfoAboutTypeConcert.Note,
                    Age = ((Party)c.InfoAboutTypeConcert).Age
                };
            }
            else if (c.InfoAboutTypeConcert is OpenAir)
            {
                concert.InfoATC = new OpenAir()
                {
                    Note = c.InfoAboutTypeConcert.Note,
                    Headliner = ((OpenAir)c.InfoAboutTypeConcert).Headliner,
                    HowToGetThere = ((OpenAir)c.InfoAboutTypeConcert).HowToGetThere
                };
            }
            foreach (var t in c.Tickets)
            {
                concert.Tickets.Add(t.Ticket);
            }
            return concert;
        }

    }
}
