using Caixa.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caixa.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(i => i.Id);

            builder.Property(x => x.CPF)
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();
            
            builder.Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            
        }
    }
}
