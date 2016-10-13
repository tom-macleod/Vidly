namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "name", c => c.String());
        }
    }
}
