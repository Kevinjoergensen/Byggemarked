namespace HomeDepotWebApp.Migrations
{
    using HomeDepotWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeDepotWebApp.Storage.HomeDepotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HomeDepotWebApp.Storage.HomeDepotContext context)
        {
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Name = "Kultivator" });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Name = "Båndsliber" });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Name = "Rystepudser" });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Name = "Kompressor" });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Name = "Slagboremaskine" });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Name = "Græsslåmaskine" });
                         
            context.Costumers.AddOrUpdate(c => c.Name, new Costumer { Name = "Kevin Jørgensen"});
            
        }
    }
}
