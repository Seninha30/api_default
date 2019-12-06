

using Default.Domain.Entity;
using Default.Domain.ObjectValues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Default.Infra.Persistence.MAP
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ativo).HasDefaultValue(true);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.DataAlteracao).IsRequired();
            builder.Property(x => x.PassWord).HasMaxLength(36).IsRequired();
            builder.OwnsOne<Nome>(x => x.Nome, cb => {
                cb.Property(x => x.PrimeiroNome).HasMaxLength(50).HasColumnName("PrimeiroNome").IsRequired();
                cb.Property(x => x.UltimoNome).HasMaxLength(50).HasColumnName("Ultimonome").IsRequired();
            });
            builder.OwnsOne<Email>(x => x.Email, cb =>
            {
                cb.Property(x => x.Endereco).HasColumnName("EnderecoEmail").IsRequired();
            });
        }        
    }
}
