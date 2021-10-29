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
        private IUserRepository _userRepository;
        private IVoiceTypeRepository _voiceTypeRepository;

        public DataManager(
            IConcertsRepository concertsRepository)
        {
            _concertsRepository = concertsRepository;
        }

        public IConcertsRepository Concerts { get { return _concertsRepository; } }
    }
}
