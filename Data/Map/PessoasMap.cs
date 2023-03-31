using DesafioDev2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDev2.Data.Map
{
    public class PessoasMap : IEntityTypeConfiguration<PessoasModel>
    {
        public void Configure(EntityTypeBuilder<PessoasModel> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
        }
    }
}
