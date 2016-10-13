namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeStampsToMovieDates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET releaseDate = '2009-11-06 00:00:00', dateAdded = '2016-10-13 00:00:00' WHERE name = 'Hangover'");
            Sql("UPDATE Movies SET releaseDate = '1988-07-15 00:00:00', dateAdded = '2016-10-09 00:00:00' WHERE name = 'Die Hard'");
            Sql("UPDATE Movies SET releaseDate = '1984-12-20 00:00:00', dateAdded = '2016-10-11 00:00:00' WHERE name = 'The Terminator'");
            Sql("UPDATE Movies SET releaseDate = '1995-11-22 00:00:00', dateAdded = '2016-10-12 00:00:00' WHERE name = 'Toy Story'");
            Sql("UPDATE Movies SET releaseDate = '1997-12-19 00:00:00', dateAdded = '2016-10-13 00:00:00' WHERE name = 'Titanic'");
        }
        
        public override void Down()
        {
        }
    }
}
