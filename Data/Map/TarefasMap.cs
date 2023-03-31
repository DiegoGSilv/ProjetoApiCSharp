using DesafioDev2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDev2.Data.Map
{
    public class TarefasMap : IEntityTypeConfiguration<TarefasModel>
    {
        public void Configure(EntityTypeBuilder<TarefasModel> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}