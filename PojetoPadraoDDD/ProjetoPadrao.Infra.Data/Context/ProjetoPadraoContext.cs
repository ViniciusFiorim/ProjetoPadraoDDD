using System.Data.Entity;
using ProjetoPadrao.Domain.Entities;

namespace ProjetoPadrao.Infra.Data.Context
{
    public class ProjetoPadraoContext : DbContext
    {
        public ProjetoPadraoContext() :  base("ProjetoPadraoDDD")
        {
            
        }
        
        public DbSet<Cliente>  Clientes { get; set; }
    }
}