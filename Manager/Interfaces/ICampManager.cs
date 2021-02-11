using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Interfaces
{
    public interface ICampManager
    {

        Task<CampViewModel[]> GetAllCampsAsync(bool includeTalks = false);
        Task<List<CampViewModel>> GetAllCamps();

    }
}
