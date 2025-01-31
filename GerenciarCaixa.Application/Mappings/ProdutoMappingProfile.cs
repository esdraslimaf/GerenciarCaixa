using AutoMapper;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Application.Mappings
{
    public class ProdutoMappingProfile:Profile
    {
        public ProdutoMappingProfile()
        {
            CreateMap<ProdutoDTO, Produto>().ReverseMap();
        }
    }
}
