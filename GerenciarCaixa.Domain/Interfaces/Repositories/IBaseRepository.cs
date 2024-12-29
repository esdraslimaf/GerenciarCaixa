using GerenciarCaixa.Domain.Entities;

namespace GerenciarCaixa.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
    }
}
