using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class VoiceType
    {
        public int Id { get; set; }
        public string NameVoiceType { get; set; }

        public List<ClassicMusic> ClassicMusics { get; set; }


    }
}
