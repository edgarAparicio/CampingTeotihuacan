using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities
{
    public class Talk
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int Level { get; set; }
        public int CampId { get; set; }
        public Camp Camp { get; set; }
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}
