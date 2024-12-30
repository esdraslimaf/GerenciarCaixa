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
    public class MesaController : ControllerBase
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


        [HttpGet("buscarporestado/{estado}")]
        public IActionResult BuscarPorId(bool estado)
        {
            return Ok(_service.BuscarPorEstado(estado));
        }

        [HttpPatch("ocupar/{id}")]
        public IActionResult OcuparMesa(Guid id)
        {
            bool result = _service.OcuparMesa(id);
            if (result)
            {
                return Ok("Mesa ocupada com sucesso.");
            }
            return BadRequest("Não foi possível ocupar a mesa.");
        }

        [HttpDelete("removermesa/{id}")]
        public IActionResult DeletarMesa(Guid id)
        {
            if (_service.Delete(id)) return Ok("Removido");
            return Ok("Problema na remoção!");
        }
    }
}
