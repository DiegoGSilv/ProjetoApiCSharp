using DesafioDev2.Data.Map;
using DesafioDev2.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace DesafioDev2.Data
{
    public class SistemaTarefasDBContex : DbContext
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
            : base(options)
        {
        }

        public DbSet<PessoasModel> Pessoas { get; set; }

        public DbSet<TarefasModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoasMap());
            modelBuilder.ApplyConfiguration(new TarefasMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
