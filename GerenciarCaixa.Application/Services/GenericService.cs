using AutoMapper;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciarCaixa.Application.Services
{
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

        public async Task<Dto> AddAsync(Dto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.CreateAsync(entity);
            return dto;
        }

        public async Task<List<Dto>> GetAllAsync()
        {
            List<TEntity> lista = await _repository.GetAllAsync();
            var dtos = _mapper.Map<List<Dto>>(lista);
            return dtos;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
