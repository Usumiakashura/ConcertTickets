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
        //private IUserRepository _userRepository;
        //private IVoiceTypeRepository _voiceTypeRepository;

        public DataManager(
            IConcertsRepository concertsRepository,
            IConcertTypesRepository concertTypesRepository,
            ITicketsRepository ticketsRepository)
        {
            _concertsRepository = concertsRepository;
            _concertTypesRepository = concertTypesRepository;
            _ticketsRepository = ticketsRepository;
        }

        public IConcertsRepository Concerts { get { return _concertsRepository; } }
        public IConcertTypesRepository ConcertTypess { get { return _concertTypesRepository; } }
        public ITicketsRepository Tickets { get { return _ticketsRepository; } }

    }
}
