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


        //Diferentes formas de hacer un endpoint
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

    }
}
