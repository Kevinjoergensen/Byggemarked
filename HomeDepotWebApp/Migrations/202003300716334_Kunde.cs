namespace HomeDepotWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kunde : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    CustomerId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                    Username = c.String(),
                    Password = c.String(),
                })
                .PrimaryKey(t => t.CustomerId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
