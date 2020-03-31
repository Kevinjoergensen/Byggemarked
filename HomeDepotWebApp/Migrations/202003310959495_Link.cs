namespace HomeDepotWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Link : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PickUp = c.String(),
                        Days = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Customer_Id = c.Int(),
                        Tool_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Tools", t => t.Tool_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Tool_Id);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Depos = c.Double(nullable: false),
                        DayPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "Tool_Id", "dbo.Tools");
            DropForeignKey("dbo.Rents", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rents", new[] { "Tool_Id" });
            DropIndex("dbo.Rents", new[] { "Customer_Id" });
            DropTable("dbo.Tools");
            DropTable("dbo.Rents");
            DropTable("dbo.Customers");
        }
    }
}
