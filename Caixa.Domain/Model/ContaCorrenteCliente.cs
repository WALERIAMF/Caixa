namespace Caixa.Domain.Model
{
    public class ContaCorrenteCliente : IEntity
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdContaCorrente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
    }
}
