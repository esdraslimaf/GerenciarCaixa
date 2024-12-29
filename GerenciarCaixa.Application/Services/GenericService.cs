
using AutoMapper;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Repositories;

namespace GerenciarCaixa.Application.Services;

public class GenericService<TEntity, Dto> : IGenericService<TEntity, Dto> 
    where TEntity : BaseEntity
{
    private readonly IBaseRepository<TEntity> _repository;
    private readonly IMapper _mapper;

    public GenericService(IBaseRepository<TEntity> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public Dto Add(Dto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        _repository.Create(entity);
        return dto;
    }

    public List<Dto> GetAll()
    {
        List<TEntity> lista = _repository.GetAll();
        var dtos = _mapper.Map<List<Dto>>(lista);
        return dtos;
    }
}
