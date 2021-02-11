using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Interfaces
{
    public interface ICampManager
    {
        Task<List<Camp>> GetAllCamps();

    }
}
