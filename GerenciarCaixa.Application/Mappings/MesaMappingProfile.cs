using AutoMapper;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;

namespace GerenciarCaixa.Application.Mappings;

public class MesaMappingProfile:Profile
{
    public MesaMappingProfile()
    {
        CreateMap<MesaDTO, Mesa>();
        CreateMap<Mesa, MesaDTO>();
    }
}