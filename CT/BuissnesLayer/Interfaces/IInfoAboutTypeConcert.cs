using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IInfoAboutTypeConcert
    {
        InfoAboutTypeConcert GetInfoAboutTypeConcertById(int concertId);
        void SaveConcertType(InfoAboutTypeConcert infoATC);
    }
}
