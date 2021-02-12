using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Context;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APICampingTeotihuacan.Repository.Interfaces
{
    public interface ICampRepository
    {
        Task<Camp[]> GetAllCampsAsync(bool includeTalks = false);

        Task<List<Camp>> GetAllCamps();

        Task<Camp> GetCamp(string moniker);




    }
}
