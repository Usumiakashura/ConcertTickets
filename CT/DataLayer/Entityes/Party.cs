using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entityes
{
    //[Table("Party")]
    public class Party : InfoAboutTypeConcert
    {
        public string Age { get; set; }

    }
}
