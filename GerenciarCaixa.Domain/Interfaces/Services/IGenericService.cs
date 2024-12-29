using GerenciarCaixa.Domain.DTOs;

namespace GerenciarCaixa.Application.Services;

public interface IGenericService<TEntity, Dto> where TEntity: class
{
    Dto Add(Dto dto);
    List<Dto> GetAll();
}