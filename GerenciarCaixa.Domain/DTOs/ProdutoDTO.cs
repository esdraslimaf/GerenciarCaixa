using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.DTOs
{
    public class ProdutoDTO
    {
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public bool Disponibilidade { get; private set; }
    }
}
