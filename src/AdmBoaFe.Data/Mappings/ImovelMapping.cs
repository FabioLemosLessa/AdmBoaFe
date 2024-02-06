using AdmBoaFe.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmBoaFe.Data.Mappings
{
    public class ImovelMapping : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.ToTable("Imoveis");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(i => i.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(i => i.Imagem)
                .HasColumnType("varchar(255)");

            builder.Property(i => i.Valor)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(i => i.DataCadastro)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(i => i.Ativo)
                .IsRequired()
                .HasColumnType("bit");

            builder.HasOne(i => i.Condominio)
                .WithMany(c => c.Imovel)
                .HasForeignKey(i => i.CondominioId);

            builder.HasOne(i => i.Proprietario)
                .WithMany(p => p.Imoveis)
                .HasForeignKey(i => i.ProprietarioId);

            builder.HasOne(i => i.Logradouro)
                .WithMany() 
                .HasForeignKey(i => i.LogradouroId);
        }
    }
}
