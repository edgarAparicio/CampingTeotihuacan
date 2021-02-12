using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.ViewModels;
using EdgarAparicio.APICampingTeotihuacan.Manager.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICampingTeotihuacan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {
        private readonly ICampManager _manager;

        public CampsController(ICampManager manager)
        {
            this._manager = manager;
        }
        //public object Get()
        //{
        //    return new { Moniker = "Moniker1", Name = "Atlanta" };
        //}


        //Diferentes formas de hacer un endpoint Get
        [HttpGet("GetIActionResultInterface")]
        public async Task<IActionResult> GetIActionResultInterface()
        {
            var list = await _manager.GetAllCamps();
            return Ok(list);
        }

        [HttpGet("GetActionResult")]
        public async Task<ActionResult<List<CampViewModel>>> GetActionResult()
        {
            var list = await _manager.GetAllCamps();
            return list;
        }

        [HttpGet("GetActionResultTryCatch")]
        public async Task<ActionResult<List<CampViewModel>>> GetActionResultTryCatch()
        {
            try
            {
                return await _manager.GetAllCamps();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }

        }

        [HttpGet("GetIncludeTalks")]
        //https://localhost:44329/api/camps/GetIncludeTalks?includeTalks=true
        public async Task<ActionResult<CampViewModel[]>> GetIncludeTalks(bool includeTalks = false)
        {
            //try
            //{
                return await _manager.GetAllCampsAsync(includeTalks);
            //}
            //catch (Exception)
            //{
            //    return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failed");
            //}
        }

        [HttpGet("{moniker}")]
        //http://localhost:6600/api/camps/ATL2018
        //Para postman el parametro a recibir debe ser llamado igual al nombre del metodo Get en este caso moniker 
        //y en postman lo mandamos asi: http://localhost:6600/api/camps/ATL2018 el ultimo slash tiene que ser el nombre del moniker
        public async Task<ActionResult<CampViewModel>> GetCamp(string moniker)
        {
            try
            {
                return await _manager.GetCamp(moniker);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }
        }

    }
}
