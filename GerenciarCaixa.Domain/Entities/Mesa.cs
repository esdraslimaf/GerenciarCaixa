using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.Entities
{
    public sealed class Mesa:BaseEntity
    {
        public string IdentificaMesa { get; private set; }
        public bool? Disponivel { get; private set; }

        private Mesa() { }

        public static Mesa Criar(string identificaMesa)
        {
            return new Mesa
            {
                IdentificaMesa = identificaMesa,
                Disponivel = true
            };
        }

        public void AtualizarMesa(string identificaMesa)
        {
            if (string.IsNullOrWhiteSpace(identificaMesa))
            {
                throw new ArgumentException("Identificação da mesa não pode ser vazia.", nameof(identificaMesa));
            }

            IdentificaMesa = identificaMesa;
        }
        public void OcuparMesa() => Disponivel = false;
        public void LiberarMesa() => Disponivel = true;

    }
}
