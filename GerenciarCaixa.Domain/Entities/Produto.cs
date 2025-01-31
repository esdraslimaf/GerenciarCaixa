using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.Entities
{
    public class Produto:BaseEntity
    {
        [Required(ErrorMessage = "Nome não pode ser vazio ou apenas espaços.")]
        [MaxLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; private set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; private set; }
        public bool Disponibilidade { get; private set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            Disponibilidade = true;
        }

        public void AtualizarPreco(decimal novoPreco)
        {
            Validar();
            Preco = novoPreco;
        }

        public void AlterarDisponibilidade(bool disponibilidade)
        {
            Disponibilidade = disponibilidade;
        }

        public void AlterarNomeProduto(string nome)
        {
            Validar();
            Nome = nome;          
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new ArgumentException("O nome do produto não pode ser vazio.");

            if (Preco < 0)
                throw new ArgumentException("O preço não pode ser negativo.");
        }
    }
}
