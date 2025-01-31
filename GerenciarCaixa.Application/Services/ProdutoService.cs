using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
           _produtoRepository = produtoRepository;
        }


    }
}
