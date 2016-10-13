namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (name, releaseDate, dateAdded, genreId, numberInStock) VALUES ('Hangover', 11/06/2009, 10/13/2016, 5, 5)");
            Sql("INSERT INTO Movies (name, releaseDate, dateAdded, genreId, numberInStock) VALUES ('Die Hard', 15/07/1988, 10/11/2016, 1, 2)");
            Sql("INSERT INTO Movies (name, releaseDate, dateAdded, genreId, numberInStock) VALUES ('The Terminator', 20/12/1984, 10/12/2016, 1, 4)");
            Sql("INSERT INTO Movies (name, releaseDate, dateAdded, genreId, numberInStock) VALUES ('Toy Story', 22/11/1995, 10/10/2016, 3, 3)");
            Sql("INSERT INTO Movies (name, releaseDate, dateAdded, genreId, numberInStock) VALUES ('Titanic', 12/19/1997, 10/13/2016, 4, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
