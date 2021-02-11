using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels
{
    public class CampViewModel
    {
        public string Name { get; set; }
        public string Moniker { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; } = 1;
    }
}
