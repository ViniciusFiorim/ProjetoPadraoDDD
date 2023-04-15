using System.Data.Entity.ModelConfiguration;
using Domain.Entities.Cliente;

namespace Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.SobreNome).IsRequired().HasMaxLength(150);
            Property(c => c.Email).IsRequired().HasMaxLength(200);
            Property(c => c.Celular).IsRequired().HasMaxLength(200);
            Property(c => c.Cep).IsRequired().HasMaxLength(8);
        }
    }
}