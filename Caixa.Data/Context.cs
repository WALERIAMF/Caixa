using Microsoft.EntityFrameworkCore;
using Caixa.Domain;
using Caixa.Data.Map;
using Caixa.Domain.Model;

namespace Caixa.Domain
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ContaCorrente> ContaCorrente { get; set; }
        public DbSet<ContaCorrenteCliente> ContaCorrenteCliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContaCorrenteMap());
            modelBuilder.ApplyConfiguration(new ContaCorrenteClienteMap());


            base.OnModelCreating(modelBuilder);
        }
    }

}
