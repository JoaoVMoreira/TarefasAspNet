using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarefas.Models;

namespace Tarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id); //Informando ID
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255); //Informando campo como obrigatorio e definindo o numero maximo de caracteres
            builder.Property(x => x.Descricao).HasMaxLength(1000); //Informando campo como obrigatorio e definindo o numero maximo de caracteres
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
