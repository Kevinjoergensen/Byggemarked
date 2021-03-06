﻿namespace HomeDepotWebApp.Migrations
{
    using HomeDepotWebApp.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeDepotWebApp.Storage.HomeDepotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HomeDepotWebApp.Storage.HomeDepotContext context)
        {
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 1, Name = "Kultivator", Description = "River jorden op", Depos = 100, DayPrice = 50 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 2, Name = "Motersav", Description = "Nem og kraftfuld maskine", Depos = 75, DayPrice = 25 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 3, Name = "Slagboremaskine", Description = "Kan bore igennem hvad som helst", Depos = 50, DayPrice = 40 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 4, Name = "Græsslåmaskine", Description = "Slår græsset hurtigere end en veganer kan spise det", Depos = 125, DayPrice = 150 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 5, Name = "Vinkelsliber", Description = "Sliber dine stoleben ned i børnestørrelse", Depos = 115, DayPrice = 170 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 6, Name = "Højtryksrenser", Description = "Fjerner diverse misfarvninger", Depos = 50, DayPrice = 120 });

            context.Customers.AddOrUpdate(c => c.Name, new Customer { CustomerId = 1, Name = "John Doe", Email = "JD@live.dk", Username = "JohnD", Password = "123" });
            context.Customers.AddOrUpdate(c => c.Name, new Customer { CustomerId = 2, Name = "Kevin Jørgensen", Email = "eaakej@students.eaaa.dk", Username = "KevinJ", Password = "123" });
            context.Customers.AddOrUpdate(c => c.Name, new Customer { CustomerId = 3, Name = "Matias Rask Lauridsen", Email = "eaamrla@students.eaaa.dk", Username = "MatiasRL", Password = "123" });
            context.Customers.AddOrUpdate(c => c.Name, new Customer { CustomerId = 4, Name = "Markus Winterberg", Email = "eaamknw@students.eaaa.dk", Username = "MarkusW", Password = "1234" });
        }
    }
}
