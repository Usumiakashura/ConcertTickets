using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class ClassicMusic : InfoAboutTypeConcert
    {
        //public int Id { get; set; }
        //public string NameType { get; set; }
        public string NameConcert { get; set; }
        public string Composer { get; set; }
        public VoiceType VoiceType { get; set; }

    }
}
