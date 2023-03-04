using System.Data.Entity.Migrations;
using Infra.Data.Context;

namespace Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoModeloContext context)
        {
            // base.Seed(context);
        }
    } 
}