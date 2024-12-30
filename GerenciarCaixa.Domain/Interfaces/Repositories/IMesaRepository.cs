using GerenciarCaixa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.Interfaces.Repositories
{
    public interface IMesaRepository:IBaseRepository<Mesa>
    {
        bool LiberarMesa(Guid id);
    }
}
