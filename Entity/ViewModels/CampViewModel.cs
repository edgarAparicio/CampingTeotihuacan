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

        //las dos siguientes Propiedades son de Entidad Location
        //Al agregarle al inicio la palabra Location a las propiedades, automapper por defecto sabe que son propiedades de la entidad location
        //public string LocationVenueName { get; set; }
        //public string LocationCityTown { get; set; }
        //y automaticamente automapper asiganara los valores a estas propiedades pero regresar el modelo con estos nombres no es bueno
        //Lo que debemos hacer es dejar las propiedades tal cual y hacer una pequeña configuracion en la clase CampProfile
        //Donde le indicamos el mapeo mediante la etiqueta .ForMember y .MapFrom
        public string Venue { get; set; }
        //public string CityTown { get; set; }

        //Se agrega para poder accesar al viewmodel Talk
        public ICollection<TalkViewModel> Talks { get; set; }

    }
}
