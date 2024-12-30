using GerenciarCaixa.Application.Services;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.Interfaces.Services
{
    public interface IMesaService:IGenericService<Mesa, MesaDTO>
    {
        bool LiberarMesa(Guid id);
        IEnumerable<Mesa> BuscarPorEstado(bool estado);
        bool OcuparMesa(Guid id);
    }
}
