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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        public BaseRepository(MyContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
