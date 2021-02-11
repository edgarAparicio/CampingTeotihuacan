using AutoMapper;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels;
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
        private readonly IMapper _mapper;

        public CampManager(ICampRepository repository, IMapper mapper)
        {
            _repository = repository;
            this._mapper = mapper;
        }
        public async Task<List<CampViewModel>> GetAllCamps()
        {
            var listEntity = await _repository.GetAllCamps();
            List<CampViewModel> listViewModel = _mapper.Map<List<CampViewModel>>(listEntity);
            return listViewModel;
        }

        public async Task<CampViewModel[]> GetAllCampsAsync(bool includeTalks = false)
        {
            var listEntity = await _repository.GetAllCampsAsync();

            CampViewModel[] listViewModel = _mapper.Map<CampViewModel[]>(listEntity);
            return listViewModel;
        }
    }
}
