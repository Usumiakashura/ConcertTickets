using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer
{
    public class DataManager
    {
        private IConcertsRepository _concertsRepository;
        private IConcertTypesRepository _concertTypesRepository;
        private ITicketsRepository _ticketsRepository;
        private IInfoAboutTypeConcert _infoAboutTypeConcert;
        //private IUserRepository _userRepository;
        //private IVoiceTypeRepository _voiceTypeRepository;

        public DataManager(
            IConcertsRepository concertsRepository,
            IConcertTypesRepository concertTypesRepository,
            ITicketsRepository ticketsRepository,
            IInfoAboutTypeConcert infoAboutTypeConcert)
        {
            _concertsRepository = concertsRepository;
            _concertTypesRepository = concertTypesRepository;
            _ticketsRepository = ticketsRepository;
            _infoAboutTypeConcert = infoAboutTypeConcert;
        }

        public IConcertsRepository Concerts { get { return _concertsRepository; } }
        public IConcertTypesRepository ConcertTypess { get { return _concertTypesRepository; } }
        public ITicketsRepository Tickets { get { return _ticketsRepository; } }
        public IInfoAboutTypeConcert InfoAboutTypeConcerts { get { return _infoAboutTypeConcert; } }


    }
}
