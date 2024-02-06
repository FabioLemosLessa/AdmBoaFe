using AdmBoaFe.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmBoaFe.Data.Mappings
{
    public class CondominioMapping : IEntityTypeConfiguration<Condominio>
    {
        public void Configure(EntityTypeBuilder<Condominio> builder)
        {
            builder.ToTable("Condominios");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Descricao)
                .HasColumnType("text");

            builder.Property(c => c.DataFundacao)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(c => c.NumeroBlocos)
                .IsRequired();

            builder.Property(c => c.NumeroTotalUnidades)
                .IsRequired();

            builder.Property(c => c.AreaTotal)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(c => c.TaxaCondominioMensal)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(c => c.ContatoSindico)
                .HasColumnType("varchar(50)");

            builder.Property(c => c.ContatoAdministracao)
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.HasOne(c => c.Logradouro)
                .WithMany() 
                .HasForeignKey(c => c.LogradouroId);

            builder.HasMany(c => c.Imovel)
                .WithOne(i => i.Condominio)
                .HasForeignKey(i => i.CondominioId);
        }
    }
}
