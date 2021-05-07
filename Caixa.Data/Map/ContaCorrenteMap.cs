using Caixa.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caixa.Data.Map
{
    public class ContaCorrenteMap : IEntityTypeConfiguration<ContaCorrente>
    {
        public void Configure(EntityTypeBuilder<ContaCorrente> builder)
        {
            builder.ToTable("ContaCorrente");

            builder.HasKey(i => i.Id);

            builder.Property(x => x.Agencia)
                .HasColumnType("varchar(6)")
                .IsRequired();
            
            builder.Property(x => x.Numero)
                .HasColumnType("varchar(12)")
                .IsRequired();

            builder.Property(x => x.Saldo)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Titular)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}

