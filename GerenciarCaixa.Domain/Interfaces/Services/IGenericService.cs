using GerenciarCaixa.Domain.DTOs;

namespace GerenciarCaixa.Application.Services;

public interface IGenericService<TEntity, Dto> where TEntity: class
{
    Task<Dto> AddAsync(Dto dto);
    Task<List<Dto>> GetAllAsync();
    Task<bool> DeleteAsync(Guid id);
}