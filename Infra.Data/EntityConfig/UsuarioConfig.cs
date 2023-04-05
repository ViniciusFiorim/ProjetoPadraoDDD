using System.Data.Entity.ModelConfiguration;
using Domain.Entities.Usuario;

namespace Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.NomeCompleto).IsRequired().HasMaxLength(200);
            Property(c => c.Login).IsRequired().HasMaxLength(16);
            Property(c => c.Email).IsRequired().HasMaxLength(200);
            Property(c => c.Senha).IsRequired().HasMaxLength(8);
            Property(c => c.IsAdmin).IsRequired();
        }
    }
}