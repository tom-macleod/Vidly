namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDateColumnsInMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET releaseDate = 2009-11-06, dateAdded = 2016-10-13 WHERE name = 'Hangover'");
            Sql("UPDATE Movies SET releaseDate = 1988-07-15, dateAdded = 2016-10-09 WHERE name = 'Die Hard'");
            Sql("UPDATE Movies SET releaseDate = 1984-12-20, dateAdded = 2016-10-11 WHERE name = 'The Terminator'");
            Sql("UPDATE Movies SET releaseDate = 1995-11-22, dateAdded = 2016-10-12 WHERE name = 'Toy Story'");
            Sql("UPDATE Movies SET releaseDate = 1997-12-19, dateAdded = 2016-10-13 WHERE name = 'Titanic'");
        }
        
        public override void Down()
        {
        }
    }
}
