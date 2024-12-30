using GerenciarCaixa.Application.Services;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Services;
using GerenciarCaixa.Persistence.Context;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCaixa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MesaController:ControllerBase
    {

        public IMesaService _service { get; set; }
        public MesaController(IMesaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_service.GetAll());
        }

        [HttpPost]
        public IActionResult AddMesa([FromBody] MesaDTO mesa)
        {
            return Ok(_service.Add(mesa));
        }

        [HttpPost("liberar")]
        public IActionResult LiberarMesa(Guid id)
        {
            return Ok(_service.LiberarMesa(id));
        }
    }
}
