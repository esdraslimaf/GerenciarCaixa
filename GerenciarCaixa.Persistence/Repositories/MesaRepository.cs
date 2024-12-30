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
    public class MesaRepository : BaseRepository<Mesa>, IMesaRepository
    {
        private MyContext _context;
        public MesaRepository(MyContext context) : base(context)
        {
            _context = context;
        }

        public bool LiberarMesa(Guid id)
        {
            var mesa = _context.Mesas.Find(id);
            if (mesa == null)
            {
                throw new Exception("Mesa não encontrada.");
            }
            mesa.LiberarMesa();
            _context.SaveChanges();
            return true;
        }
    }
}
