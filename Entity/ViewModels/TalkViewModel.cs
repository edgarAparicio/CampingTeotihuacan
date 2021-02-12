using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels
{
    public class TalkViewModel
    {
        public int TalkId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int Level { get; set; }

        //Para acceder al ViewModel Speaker

        public SpeakerViewModel Speaker { get; set; }
    }
}
