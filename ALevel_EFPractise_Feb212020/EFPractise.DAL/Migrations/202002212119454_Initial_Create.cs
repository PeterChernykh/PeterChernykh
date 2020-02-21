namespace EFPractise.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gemstones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Price = c.Int(nullable: false),
                        Name = c.String(),
                        GemstoneTypeId = c.Int(nullable: false),
                        Jewellery_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GemstoneTypes", t => t.GemstoneTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Jewelleries", t => t.Jewellery_Id)
                .Index(t => t.GemstoneTypeId)
                .Index(t => t.Jewellery_Id);
            
            CreateTable(
                "dbo.GemstoneTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jewelleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Name = c.String(),
                        ManufactorerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufactorerId, cascadeDelete: true)
                .Index(t => t.ManufactorerId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContryId = c.Int(nullable: false),
                        Name = c.String(),
                        LicenseNumber = c.Long(nullable: false),
                        DataCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jewelleries", "ManufactorerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Gemstones", "Jewellery_Id", "dbo.Jewelleries");
            DropForeignKey("dbo.Gemstones", "GemstoneTypeId", "dbo.GemstoneTypes");
            DropIndex("dbo.Jewelleries", new[] { "ManufactorerId" });
            DropIndex("dbo.Gemstones", new[] { "Jewellery_Id" });
            DropIndex("dbo.Gemstones", new[] { "GemstoneTypeId" });
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Jewelleries");
            DropTable("dbo.GemstoneTypes");
            DropTable("dbo.Gemstones");
        }
    }
}
