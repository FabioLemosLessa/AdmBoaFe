using AdmBoaFe.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmBoaFe.Data.Mappings
{
    public class ProprietarioMapping : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.ToTable("Proprietarios");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TipoProprietario)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne(p => p.Logradouro)
                .WithMany() 
                .HasForeignKey(p => p.LogradouroId);

            builder.HasMany(p => p.Imoveis)
                .WithOne(i => i.Proprietario)
                .HasForeignKey(i => i.ProprietarioId);
        }
    }
}
