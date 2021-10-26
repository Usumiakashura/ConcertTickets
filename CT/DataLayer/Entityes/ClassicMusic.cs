using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entityes
{
    //[Table("ClassicMusic")]
    public class ClassicMusic : InfoAboutTypeConcert
    {
        public string NameConcert { get; set; }
        public string Composer { get; set; }
        public VoiceType VoiceType { get; set; }

    }
}
