namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 225),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Movies", "releaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "dateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "genreId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "numberInStock", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "genreId");
            AddForeignKey("dbo.Movies", "genreId", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "genreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "genreId" });
            DropColumn("dbo.Movies", "numberInStock");
            DropColumn("dbo.Movies", "genreId");
            DropColumn("dbo.Movies", "dateAdded");
            DropColumn("dbo.Movies", "releaseDate");
            DropTable("dbo.Genres");
        }
    }
}
