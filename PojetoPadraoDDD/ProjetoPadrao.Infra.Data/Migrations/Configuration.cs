
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ProjetoPadrao.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoPadrao.Infra.Data.Context.ProjetoPadraoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}