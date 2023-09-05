using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarefas.Models;

namespace Tarefas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id); //Informando ID
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255); //Informando campo como obrigatorio e definindo o numero maximo de caracteres
            builder.Property(x => x.email).IsRequired().HasMaxLength(155); //Informando campo como obrigatorio e definindo o numero maximo de caracteres
        }
    }
}
