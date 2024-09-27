using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Persistence.Repositories
{
    public class MesaRepository:BaseRepository<Mesa>, IMesaRepository
    {
        public MesaRepository(MyContext context):base(context)
        {
            
        }
    }
}
