namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (id, name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (id, name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (id, name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (id, name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (id, name) VALUES (5, 'Comedy')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
