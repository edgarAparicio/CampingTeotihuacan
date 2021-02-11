using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using EdgarAparicio.APICampingTeotihuacan.Manager.Interfaces;
using EdgarAparicio.APICampingTeotihuacan.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APICampingTeotihuacan.Manager.Manager
{
    public class CampManager : ICampManager
    {
        private readonly ICampRepository _repository;

        public CampManager(ICampRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Camp>> GetAllCamps()
        {
            return await _repository.GetAllCamps();
        }
    }
}
