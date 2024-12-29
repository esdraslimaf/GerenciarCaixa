using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Interfaces.Services;

namespace GerenciarCaixa.Persistence.Repositories
{
    public class MesaRepository:BaseRepository<Mesa>, IMesaRepository
    {
        private IGenericService<CreateMesaDTO, Mesa> _service { get; set; }
        public MesaRepository(MyContext context):base(context)
        {
            
        }
        
        
        
    }
}
