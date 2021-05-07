using Caixa.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caixa.Data.Map
{
    public class ContaCorrenteClienteMap : IEntityTypeConfiguration<ContaCorrenteCliente>
    {

        public void Configure(EntityTypeBuilder<ContaCorrenteCliente> builder)
        {
            builder.ToTable("ContaCorrenteCliente");

            builder.HasKey(x => new { x.Cliente, x.ContaCorrente });

            builder.HasOne(i => i.Cliente)
                .WithMany(cc => cc.ContaCorrenteCliente)
                .HasForeignKey(i => i.IdCliente);

            builder.HasOne(i => i.ContaCorrente)
                .WithMany(cc => cc.ContaCorrenteCliente)
                .HasForeignKey(i => i.IdContaCorrente);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

        }
    }
}
