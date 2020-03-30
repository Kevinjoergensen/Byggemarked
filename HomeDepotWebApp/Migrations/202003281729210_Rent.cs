namespace HomeDepotWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rents",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PickUp = c.String(),
                    Days = c.Int(nullable: false),
                    Status = c.Boolean(nullable: false),
                    CustomerId = c.Int(),
                    ToolId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Tools", t => t.ToolId);
                
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "ToolId", "dbo.Tools");
            DropForeignKey("dbo.Rents", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Rents", new[] { "RentTool_Id" });
            DropIndex("dbo.Rents", new[] { "Customer_CustomerId" });
            DropTable("dbo.Rents");
        }
    }
}
