using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities
{
    public class Camp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Moniker { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; } = 1;
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public ICollection<Talk> Talks { get; set; }

    }
}
