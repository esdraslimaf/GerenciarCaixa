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
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddMesa([FromBody] MesaDTO mesa)
        {
            return Ok(await _service.AddAsync(mesa));
        }

        [HttpPost("liberar")]
        public async Task<IActionResult> LiberarMesa(Guid id)
        {
            return Ok(await _service.LiberarMesaAsync(id));
        }


        [HttpGet("buscarporestado/{estado}")]
        public async Task<IActionResult> BuscarPorId(bool estado)
        {
            return Ok(await _service.BuscarPorEstadoAsync(estado));
        }

        [HttpPatch("ocupar/{id}")]
        public async Task<IActionResult> OcuparMesa(Guid id)
        {
            bool result = await _service.OcuparMesaAsync(id);
            if (result)
            {
                return Ok("Mesa ocupada com sucesso.");
            }
            return BadRequest("Não foi possível ocupar a mesa.");
        }

        [HttpDelete("removermesa/{id}")]
        public async Task<IActionResult> DeletarMesa(Guid id)
        {
            if (await _service.DeleteAsync(id)) return Ok("Removido");
            return Ok("Problema na remoção!");
        }
    }
}
