namespace HomeDepotWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rents : DbMigration
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
                    Status = c.Int(),
                    Costumer_CostumerId = c.Int(),
                    RentTool_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Costumers", t => t.Costumer_CostumerId)
            .ForeignKey("dbo.Tools", t => t.RentTool_Id)
            .Index(t => t.Costumer_CostumerId)
            .Index(t => t.RentTool_Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "RentTool_Id", "dbo.Tools");
            DropForeignKey("dbo.Rents", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Rents", new[] { "RentTool_Id" });
            DropIndex("dbo.Rents", new[] { "Customer_CustomerId" });
            DropTable("dbo.Rents");
        }
    }
}
