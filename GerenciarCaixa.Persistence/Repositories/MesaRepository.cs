using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Persistence.Context;
using Microsoft.EntityFrameworkCore;
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
        private DbSet<Mesa> _dbSet;
        public MesaRepository(MyContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Mesa>();
        }

        public IEnumerable<Mesa> FindByState(bool estado)
        {
            return _dbSet.Where(m => m.Disponivel == estado);
        }

    }
}
