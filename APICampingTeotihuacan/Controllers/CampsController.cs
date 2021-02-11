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
        public object Get()
        {
            return new { Moniker = "Moniker1", Name = "Atlanta" };
        }
    }
}
