using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id); //define a chave primária
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255); //define que a propriedade nome é necessária
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
        }
    }
}
