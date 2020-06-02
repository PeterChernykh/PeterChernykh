namespace ALvl_ExamProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ordertableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.OrderDetails", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderDetails", "UserId", c => c.Int(nullable: false));
            DropTable("dbo.Orders");
        }
    }
}
