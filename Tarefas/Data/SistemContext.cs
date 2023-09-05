using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Tarefas.Data.Map;
using Tarefas.Models;

namespace Tarefas.Data
{
    public class SistemContext: DbContext
    {
        public SistemContext(DbContextOptions<SistemContext> options)
            :base(options) 
        {}

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
