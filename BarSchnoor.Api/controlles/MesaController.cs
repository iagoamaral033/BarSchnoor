using BarSchnoor.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarSchnoor.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MesaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Mesa>> Get()
        {
            return Ok(new List<Mesa>());
        }

        [HttpPost]
        public ActionResult<Mesa> Post(Mesa mesa)
        {
            return Ok(mesa);
        }
    }
}