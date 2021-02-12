using AutoMapper;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Configuration
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            //this.CreateMap<Camp, CampViewModel>().ReverseMap();

            this.CreateMap<Camp, CampViewModel>()
                .ForMember(c => c.Venue, o => o.MapFrom(l => l.Location.VenueName));

            this.CreateMap<Talk, TalkViewModel>();

            this.CreateMap<Speaker, SpeakerViewModel>();



        }
    }
}
