using GerenciarCaixa.Domain.Entities;

namespace GerenciarCaixa.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        bool Delete(Guid id);
        List<T> GetAll();
        void SaveChanges();
        T? FindById(Guid id);
        bool Exists(Guid id);
    }
}
