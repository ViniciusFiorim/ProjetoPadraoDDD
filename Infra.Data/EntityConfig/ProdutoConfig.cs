using System.Data.Entity.ModelConfiguration;
using Domain.Entities.Produto;

namespace Infra.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Nome).IsRequired().HasMaxLength(250);
            Property(c => c.Valor).IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}