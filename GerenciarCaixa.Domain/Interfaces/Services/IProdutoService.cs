using GerenciarCaixa.Application.Services;
using GerenciarCaixa.Domain.DTOs;
using GerenciarCaixa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.Interfaces.Services
{
    public interface IProdutoService:IGenericService<Produto, ProdutoDTO>
    {
    }
}
