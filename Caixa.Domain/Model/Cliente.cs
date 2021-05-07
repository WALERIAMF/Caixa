using Caixa.Domain.Model;
using System.Collections.Generic;

namespace Caixa.Domain
{
    public class Cliente : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public List<ContaCorrenteCliente> ContaCorrenteCliente { get; set; }
    }
}
