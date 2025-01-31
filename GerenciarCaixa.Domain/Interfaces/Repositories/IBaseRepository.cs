using GerenciarCaixa.Domain.Entities;

namespace GerenciarCaixa.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task SaveChangesAsync();
        Task<T?> FindByIdAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<IEnumerable<T>> ObterTodosAsyncViaDapper(string tipo);
    }
}
