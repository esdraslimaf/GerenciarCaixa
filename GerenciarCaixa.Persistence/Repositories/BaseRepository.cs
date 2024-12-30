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
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public bool Delete(Guid id)
        {
            T UserDeletar = _context.Set<T>().Find(id);
            if (UserDeletar != null) {
                _context.Set<T>().Remove(UserDeletar);
                    _context.SaveChanges();
                return true;
            }
            else throw new Exception("Entidade não encontrada.");
        }

        public List<T> GetAll()
        {  
            var query = _context.Set<T>().AsQueryable();
            return query.ToList();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges(); 
        }

        public T? FindById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Exists(Guid id)
        {
            if (_context.Set<T>().Find(id) != null) return true;
            return false;
        }
    }
}
