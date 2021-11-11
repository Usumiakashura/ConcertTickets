using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFInfoAboutTypeConcert : IInfoAboutTypeConcert
    {
        private ApplicationDbContext _context;

        public EFInfoAboutTypeConcert(ApplicationDbContext context)
        {
            _context = context;
        }

        public InfoAboutTypeConcert GetInfoAboutTypeConcertById(int id)
        {
            var iatc = _context.InfoAboutTypeConcerts.Find(id);
            var c = _context.ClassicMusics.Find(id);
            if (iatc is ClassicMusic)
            {
                return new ClassicMusic()
                {
                    Id = iatc.Id,
                    ConcertType = iatc.ConcertType,
                    Note = iatc.Note,
                    NameConcert = c.NameConcert,
                    Composer = c.Composer,
                    VoiceType = _context.VoiceTypes.Find(c.VoiceTypeId)
                };
            }
            else if (iatc is OpenAir)
            {
                return new OpenAir()
                {
                    Id = iatc.Id,
                    Note = iatc.Note,
                    Headliner = _context.OpenAirs.Find(id).Headliner,
                    HowToGetThere = _context.OpenAirs.Find(id).HowToGetThere
                };
            }
            else if (iatc is Party)
            {
                return new Party()
                {
                    Id = iatc.Id,
                    Note = iatc.Note,
                    Age = _context.Parties.Find(id).Age
                };
            }
            else return _context.InfoAboutTypeConcerts.Find(id);
        }

        public void SaveConcertType(InfoAboutTypeConcert infoATC)
        {
            if (infoATC.Id == 0)
                _context.InfoAboutTypeConcerts.Add(infoATC);
            else
                _context.Entry(infoATC).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
