using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entityes
{
    public class InfoAboutTypeConcert
    {
        [Key]
        [ForeignKey("Concert")]
        public int Id { get; set; } //айди типа равен ацди концерта
        public string Note { get; set; }

        public Concert Concert { get; set; }

        public int? ConcertTypeId { get; set; }
        public ConcertType ConcertType { get; set; }

        



    }
}
