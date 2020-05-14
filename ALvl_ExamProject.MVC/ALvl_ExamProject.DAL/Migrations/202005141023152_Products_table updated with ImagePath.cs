namespace ALvl_ExamProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products_tableupdatedwithImagePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImagePath");
            DropColumn("dbo.Products", "Description");
        }
    }
}
