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
            return Ok(Mesa.Listar());
        }
        [HttpPost]
        public ActionResult<Mesa> Post(Mesa mesa)
        {
            Mesa.Cadastrar(mesa);
            return Ok(mesa);
        }
    }
}