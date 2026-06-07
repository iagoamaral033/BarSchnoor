using BarSchnoor.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarSchnoor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("cliente/listar")]
        public IActionResult ListarClientes()
        {
            return Ok(new Cliente());
        }
        [HttpPut]
        [Route("cliente/{id}")]
        public IActionResult AlterarCliente(int id)
        {
            return Ok(new Cliente());
        }
    }
}
