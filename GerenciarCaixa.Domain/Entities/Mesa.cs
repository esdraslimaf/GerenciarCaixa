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
        public bool Disponivel { get; private set; }

        public Mesa() { }
        public Mesa(string identificaMesa, bool disponivel)
        {
            if (string.IsNullOrWhiteSpace(identificaMesa))
            {
                throw new ArgumentNullException(nameof(identificaMesa), "Identificação da mesa não pode ser nula ou vazia.");
            }
            this.IdentificaMesa = identificaMesa;
            this.Disponivel = disponivel;
        }

        public void OcuparMesa() => Disponivel = false;
        public void LiberarMesa() => Disponivel = true;

    }
}
