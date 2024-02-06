using AdmBoaFe.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmBoaFe.Data.Mappings
{
    public class InquilinoMapping : IEntityTypeConfiguration<Inquilino>
    {
        public void Configure(EntityTypeBuilder<Inquilino> builder)
        {
            builder.ToTable("Inquilinos");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(i => i.TipoInquilino)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne(i => i.Logradouro)
                .WithMany() 
                .HasForeignKey(i => i.LogradouroId);

            builder.HasOne(i => i.Imovel)
                .WithOne() 
                .HasForeignKey<Imovel>(i => i.InquilinoId); 
        }
    }
}
