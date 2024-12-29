using GerenciarCaixa.Application.Services;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Persistence.Context;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCaixa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MesaController:ControllerBase
    {

        public IGenericService<Mesa, MesaDTO> _service { get; set; }
        public MesaController(IGenericService<Mesa, MesaDTO> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_service.GetAll());
        }

    }
}
