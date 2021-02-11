using AutoMapper;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Migrations
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampViewModel>();
        }
    }
}
