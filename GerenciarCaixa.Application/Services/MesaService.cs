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
            var mesa = _mesaRepository.FindById(id);
            if (mesa == null)
            {
                throw new Exception("Mesa não encontrada.");
            }
            if (mesa.Disponivel)
            {
                throw new Exception("A mesa já está livre.");
            }
            mesa.DateUpdated = DateTime.Now;
            mesa.LiberarMesa();
            _mesaRepository.SaveChanges(); 
            return true;
        }

        public bool OcuparMesa(Guid id)
        {
            var mesa = _mesaRepository.FindById(id);
            if (mesa == null)
            {
                throw new Exception("Mesa não encontrada.");
            }
            if (!mesa.Disponivel)
            {
                throw new Exception("A mesa já está ocupada.");
            }
            mesa.DateUpdated = DateTime.Now;
            mesa.OcuparMesa();
            _mesaRepository.SaveChanges();
            return true;
        }

        public IEnumerable<Mesa> BuscarPorEstado(bool estado)
        {
            var mesas = _mesaRepository.FindByState(estado);
            if(mesas!=null) return mesas;
            throw new Exception("Mesas não encontradas!");
        }


    }
}
