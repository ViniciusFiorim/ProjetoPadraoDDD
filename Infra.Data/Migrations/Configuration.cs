using System.Data.Entity.Migrations;
using Infra.Data.Context;

namespace Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ProjetoModeloContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
