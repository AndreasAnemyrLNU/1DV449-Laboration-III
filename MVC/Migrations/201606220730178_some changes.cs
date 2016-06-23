namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somechanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Createddate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Messages", "Latitude", c => c.String());
            AlterColumn("dbo.Messages", "Longitude", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "Longitude", c => c.Single(nullable: false));
            AlterColumn("dbo.Messages", "Latitude", c => c.Single(nullable: false));
            DropColumn("dbo.Messages", "Createddate");
        }
    }
}
