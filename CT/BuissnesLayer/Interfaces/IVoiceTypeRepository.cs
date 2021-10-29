using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IVoiceTypeRepository
    {
        IEnumerable<VoiceType> GetAllVoiceTypes();
        VoiceType GetVoiceTypeById(int voiceTypeId);
        void SaveVoiceType(VoiceType voiceType);
        void DeleteVoiceType(VoiceType voiceType);
    }
}
