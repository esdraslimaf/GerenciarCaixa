using Dapper;
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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private readonly DbConnectionFactory _dbConnectionFactory;
        //string nomeDoTipo = typeof(T).Name;
        public BaseRepository(MyContext context, DbConnectionFactory dbConnectionFactory)
        {
            _context = context;
            _dbConnectionFactory = dbConnectionFactory;
        }

        public BaseRepository(MyContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            T? entityToDelete = await _context.Set<T>().FindAsync(id);
            if (entityToDelete != null)
            {
                _context.Set<T>().Remove(entityToDelete);
                await _context.SaveChangesAsync();
                return true;
            }
            else throw new Exception("Entidade não encontrada.");
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T?> FindByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id) != null;
        }

        public async Task<IEnumerable<T>> ObterTodosAsyncViaDapper(string tipoQuery)
        {
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                var query = $"SELECT * FROM {tipoQuery}";
                return await connection.QueryAsync<T>(query);
            }
        }
    }
}
