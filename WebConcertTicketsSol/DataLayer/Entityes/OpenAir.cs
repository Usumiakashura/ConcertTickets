using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entityes
{
    //[Table("OpenAir")]
    public class OpenAir : InfoAboutTypeConcert
    {
        public string Headliner { get; set; }
        public string HowToGetThere { get; set; }

    }
}
