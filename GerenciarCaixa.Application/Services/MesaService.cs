using AutoMapper;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Application.Services
{
    public class MesaService : GenericService<Mesa, MesaDTO>, IMesaService
    {
        private readonly IMesaRepository _mesaRepository;

        public MesaService(IMesaRepository mesaRepository, IMapper mapper)
            : base(mesaRepository, mapper) 
        {
            _mesaRepository = mesaRepository; 
        }
        public bool LiberarMesa(Guid id)
        {
            return _mesaRepository.LiberarMesa(id);
        }
    }
}
